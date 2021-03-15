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

        #endregion


        #region Ctor
        public StaffAttendenceController(ILectureService lectureService, ISubjectService subjectService, IClassService classService, IClassSubjectDetailService classDetailService, IUserService userService)
        {
            _lectureService = lectureService;
            _classService = classService;
            _subjectService = subjectService;
            _classDetailService = classDetailService;
            _userService = userService;



        }
        #endregion

        #region Method

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult AttendenceEntry()
        {

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

            return View();
        }


        [HttpGet]
        public async Task<IActionResult> GetStudentList(JQueryDataTableParamModel param)
        {
            using (var txscope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    var parameters = CommonMethod.GetJQueryDatatableParamList(param, GetSortingColumnName(param.iSortCol_0));

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
        public async Task<IActionResult> StudentAttendenceEntry()
        {
            using (var txscope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
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



            #endregion

            #region Common


            #endregion





        }
    }
