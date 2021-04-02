using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using StudentManagement.Service.Interface;
using StudentManagement.Web.Utility.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using StudentManagement.Web.Models;
using StudentManagement.Web.Utility;
using EasyLearnerAdmin.Utility.JqueryDataTable;
using Microsoft.AspNetCore.Identity;
using StudentManagement.Data.DBContexts;
using EasyLearnerAdmin.Utility.Common;
using StudentManagement.Utility.Common;
using StudentManagement.Service.Dto;
using StudentManagement.Service.Exception;
using StudentManagement.Data.Models;
using System.Data.SqlTypes;
using System.Globalization;
using System.Data;
using Microsoft.Data.SqlClient;

namespace StudentManagement.Web.Areas.Staff.Controllers
{
    [Area("Staff")]
    [Authorize(Roles = "Staff")]
    public class StaffAttendenceController : BaseController<StaffAttendenceController>
    {
        #region Field

        private readonly ILectureService _lectureService;
        private readonly IClassService _classService;
        private readonly ISubjectService _subjectService;
        private readonly IClassSubjectDetailService _classDetailService;
        private readonly IUserService _userService;
        private readonly IAttendenceDetailService  _adService;
        private readonly IStudentAttendanceService _saService;
        private readonly ICollegeDetailService _cdService;
        private readonly IClassStudentDetailService _classStudentDetailService;
        private readonly IClassSubjectTeacherService _classSubTeacherService;
        
        #endregion


        #region Ctor
        public StaffAttendenceController(ILectureService lectureService,
            IAttendenceDetailService adService,
            IStudentAttendanceService saService,
            ISubjectService subjectService, IClassService classService, IClassSubjectDetailService classDetailService, 
            IUserService userService,
            ICollegeDetailService cdService,
            IClassSubjectTeacherService classSubTeacherService,
            IClassStudentDetailService classStudentDetailService
            )
        {
            _lectureService = lectureService;
            _classService = classService;
            _subjectService = subjectService;
            _classDetailService = classDetailService;
            _userService = userService;
            _adService = adService;
            _saService = saService;
            _cdService = cdService;
            _classStudentDetailService = classStudentDetailService;


        }
        #endregion

        #region Method

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult AttendenceEntry()
        {
            //


            var eObj = _saService.GetAll().Where(x => x.AttendanceBy == User.GetUserId() && x.AttendanceDate.ToShortDateString().Equals(DateTime.Now.ToShortDateString())).FirstOrDefault();
                var model = new StaffAttendenceDto();
            if (eObj != null) {
                model.LectureId = eObj.LectureId;   
                model.ClassId = eObj.ClassId;   
                model.SubjectId = eObj.SubjectId;   
            }
            ViewBag.lecturelist = _lectureService.GetAll(x => x.IsActive == true).Select(x => new SelectListItem
            {
                Text = x.LactureName,
                Value = x.LectureId.ToString()
            }).OrderBy(x => x.Text).ToList();


            ViewBag.ClassList = _classService.GetAll(x => x.IsActive == true).Select(x => new SelectListItem
            {
                Text = x.ClassName,
                Value = x.ClassId.ToString()
            }).OrderBy(x => x.Text).ToList();

            ViewBag.SubjectList = _subjectService.GetAll(x => x.IsActive == true).Select(x => new SelectListItem
            {
                Text = x.SubjectName,
                Value = x.SubjectId.ToString()
            }).OrderBy(x => x.Text).ToList();

            return View(model);
        }


        [HttpGet]
        public async Task<IActionResult> GetStudentList(JQueryDataTableParamModel param,long ClassId)
        {
            using (var txscope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    var parameters = CommonMethod.GetJQueryDatatableParamList(param, GetSortingColumnName(param.iSortCol_0));
                    parameters.Parameters.Insert(0, new SqlParameter("@ClassId", SqlDbType.BigInt) { Value = ClassId });
                    var allList = await _userService.GetStudentList(parameters.Parameters.ToArray());
                    var total = allList.FirstOrDefault()?.TotalRecords ?? 0;
                    return Json(new
                    {
                        param.sEcho,
                        iTotalRecords = total,
                        iTotalDisplayRecords = total,
                        aaData = allList
                    });
                }
                catch (Exception ex)
                {
                    ErrorLog.AddErrorLog(ex, "GetStudentList");
                    return Json(new
                    {
                        param.sEcho,
                        iTotalRecords = 0,
                        iTotalDisplayRecords = 0,
                        aaData = ""
                    });
                }
            }
        }



        [HttpPost]
        public async Task<IActionResult> StudentAttendenceEntry(StaffAttendenceDto model)
        {
            using (var txscope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    var isExist = _saService.GetAll().Where(x=>x.AttendanceDate.ToShortDateString().Equals(DateTime.Now.ToShortDateString()) &&
                     x.AttendanceBy == User.GetUserId()
                    );
                    if (isExist.Count() == 0)
                    {
                        StudentAttendance obj = new StudentAttendance();
                        obj.AttendanceDate = DateTime.Now;
                        obj.AttendanceBy = User.GetUserId();
                        obj.ClassId = model.ClassId;
                        obj.LectureId = model.LectureId;
                        obj.SubjectId = model.SubjectId;
                        obj.IsActive = true;

                        var insertResult = await _saService.InsertAsync(obj, Accessor, User.GetUserId());
                        if (insertResult != null)
                        {
                            foreach (var item in model.StudentIdList)
                            {
                                StudentAttendanceDetail stobj = new StudentAttendanceDetail();
                                stobj.StudentId = item;
                                stobj.IsPresent = model.Mark==1?true:false;
                                stobj.AttendanceId = insertResult.AttendanceId;
                                stobj.IsActive = true;
                                var stinsertResult = await _adService.InsertAsync(stobj, Accessor, User.GetUserId());
                                if (stinsertResult == null)
                                {
                                    txscope.Dispose();
                                    ErrorLog.AddErrorLog(null, "post/StudentAttendenceEntry");
                                    return JsonResponse.GenerateJsonResult(0, ResponseConstants.SomethingWrong);
                                }
                            }
                            txscope.Complete();
                            return JsonResponse.GenerateJsonResult(1, ResponseConstants.InsertRecord);

                        }
                    }
                    else {
                        var eObj = _saService.GetAll().Where(x => x.AttendanceBy == User.GetUserId() && x.AttendanceDate.ToShortDateString().Equals(DateTime.Now.ToShortDateString())).FirstOrDefault();

                        if (eObj != null)
                        { 
                        
                        eObj.AttendanceDate = DateTime.Now;
                        eObj.AttendanceBy = User.GetUserId();
                        eObj.ClassId = model.ClassId;
                        eObj.LectureId = model.LectureId;
                        eObj.SubjectId = model.SubjectId;
                        eObj.IsActive = true;
                        var updateResult = await _saService.UpdateAsync(eObj,Accessor,User.GetUserId());
                        if (updateResult != null)
                        {
                            var studentList = _adService.GetAll().Where(x => x.AttendanceId == updateResult.AttendanceId && model.StudentIdList.Contains(x.StudentId));
                            foreach (var studentId in model.StudentIdList)
                            {
                                var studObj = studentList.FirstOrDefault(x => x.StudentId == studentId);
                                studObj.IsPresent = model.Mark==1?true:false;
                                var stinsertResult = await _adService.UpdateAsync(studObj, Accessor, User.GetUserId());
                                if (stinsertResult == null)
                                {
                                    txscope.Dispose();
                                    ErrorLog.AddErrorLog(null, "post/StudentAttendenceEntry");
                                    return JsonResponse.GenerateJsonResult(0, ResponseConstants.SomethingWrong);
                                }
                            }
                            txscope.Complete();
                            return JsonResponse.GenerateJsonResult(1, ResponseConstants.InsertRecord);
                        }

                        }

                    }
                    txscope.Dispose();
                    ErrorLog.AddErrorLog(null, "post/StudentAttendenceEntry");
                    return JsonResponse.GenerateJsonResult(0, ResponseConstants.SomethingWrong);
                }
                catch (Exception ex)
                {
                    txscope.Dispose();
                    ErrorLog.AddErrorLog(ex, "post/StudentAttendenceEntry");
                    return JsonResponse.GenerateJsonResult(0, ResponseConstants.SomethingWrong);
                }
            }
        }

        public JsonResult getSubjectList(long ClassId)
            {
                var classSubjectDetailList = _classDetailService.GetAll(x => x.ClassId == ClassId).Select(x => x.SubjectId).ToList();

                var ddlSubjectList = _subjectService.GetAll(x => classSubjectDetailList.Contains(x.SubjectId)).ToList();
                List<SelectListItem> subjectlist = new List<SelectListItem>();


                if (ddlSubjectList != null)
                {
                    foreach (var x in ddlSubjectList)
                    {
                        subjectlist.Add(new SelectListItem { Text = x.SubjectName, Value = x.SubjectId.ToString(), Selected = true });
                    }
                }
                return Json(new SelectList(subjectlist, "Value", "Text", new Newtonsoft.Json.JsonSerializerSettings()));
            }




        public IActionResult ClassDetailForTeacher()
        {
            List<ClassDetailForTeacherDto> model = new List<ClassDetailForTeacherDto>();
          
            var ClassSubjectList = _classDetailService.GetAll().ToList();
            foreach (var cs in ClassSubjectList)
            {
                ClassDetailForTeacherDto m = new ClassDetailForTeacherDto();
                m.ClassName = _classService.GetById(cs.ClassId).ClassName;
                m.SubjectName = _subjectService.GetById(cs.SubjectId).SubjectName;
                m.ClassId = cs.ClassId;
              
                model.Add(m);
            }


            return View(model);
        }


        [HttpGet]
        public IActionResult MothWiseClassReport()
        {
            var attendencelist = _saService.GetAll().Where(x=>x.AttendanceBy==User.GetUserId()).ToList();
            var currentStudentAttendenceList = _adService.GetAll().Where(x=>attendencelist.Select(y=>y.AttendanceId).Contains(x.AttendanceId)).ToList();
            var studentReportList = new List<StudentMonthWiseDto>();
            foreach (var item in currentStudentAttendenceList)
            {
                var attendenceObj = attendencelist.FirstOrDefault(x => x.AttendanceId == item.AttendanceId);
                var model = new StudentMonthWiseDto();
                model.MonthId = attendenceObj.AttendanceDate.Month;
                model.MonthName = attendenceObj.AttendanceDate.ToString("MMMM");
                model.subjectName = _subjectService.GetSingle(x => x.SubjectId == attendenceObj.SubjectId).SubjectName;
                model.subjectHeld += 1;
                model.StudentAttendence += item.IsPresent ? 1 : 0;
                model.Percent = 0;
                model.AttendenceId = attendenceObj.AttendanceId;
                model.StudentName =_userService.GetById(item.StudentId).FirstName;
                studentReportList.Add(model);

            }

            return View(studentReportList);
        }


        [HttpGet]
        public IActionResult DayWiseReport()
        {
            List<DaywiseAttendenceDto> model = new List<DaywiseAttendenceDto>();

            var attendenceList = _saService.GetAll(x => x.AttendanceBy == User.GetUserId()).ToList();
            foreach (var item in attendenceList)
            {
                var attendenceDetail = _adService.GetAll(x => x.AttendanceId == item.AttendanceId).ToList();

                foreach (var ads in attendenceDetail) { 
                
                DaywiseAttendenceDto m = new DaywiseAttendenceDto();
                m.AttendenceDate = item.AttendanceDate;
                m.LactureName = _lectureService.GetById(item.LectureId).LactureName;
                m.SubjectName = _subjectService.GetById(item.SubjectId).SubjectName;
                m.IsPresent = ads.IsPresent;
                m.LectureId = item.LectureId;
                model.Add(m);
                }

            }

            return View(model);
        }

        public IActionResult RollListReport(long Cid)
        {
            List<StudentRollListDto> model = new List<StudentRollListDto>();
            var studList = _classStudentDetailService.GetAll(x => x.ClassId == Cid).Select(x => x.StudentId).ToList();
            foreach (var item in studList)
            {
                StudentRollListDto m = new StudentRollListDto();
                var user = _userService.GetById(item);
                m.RollNumber = _cdService.GetSingle(x => x.UserId == item).CollegeRollNumber;
                m.StudentName = user.FirstName + " " + user.LastName;
                m.StudentId = user.Id;
                model.Add(m);
            }
            

            return View(model);
        }
        #endregion

        #region Common


        #endregion



    }
    }
