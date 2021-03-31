using EasyLearnerAdmin.Utility.JqueryDataTable;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using StudentManagement.Service.Dto;
using StudentManagement.Service.Exception;
using StudentManagement.Service.Interface;
using StudentManagement.Web.Models;
using StudentManagement.Web.Utility.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

namespace StudentManagement.Web.Areas.Student.Controllers
{
    [Area("Student")]
    [Authorize(Roles = "Student")]
    public class StudentAttendenceController : BaseController<StudentAttendenceController>
    {
        #region Fields
        private readonly ILectureService _lectureService;
        private readonly IAttendenceDetailService _adService;
        private readonly IStudentAttendanceService _saService;
        private readonly ISubjectService _SubService;

        #endregion

        #region Ctor
        public StudentAttendenceController(ILectureService lectureService, IAttendenceDetailService adService, IStudentAttendanceService saService,
            ISubjectService SubService
            )
        {
            _lectureService = lectureService;
            _adService = adService;
            _saService = saService;
            _SubService = SubService;
        }

        #endregion

        #region Methods

        public IActionResult Index()
        {
         
            return View();
        }


        public IActionResult Classdetails()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetClassDetailList(JQueryDataTableParamModel param)
        {
            using (var txscope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    var parameters = CommonMethod.GetJQueryDatatableParamList(param, GetSortingColumnName(param.iSortCol_0));

                    var allList = await _adService.GetClassDetailList(parameters.Parameters.ToArray());

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
                    ErrorLog.AddErrorLog(ex, "GetClassDetailList");
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
        #endregion


        [HttpGet]
        public IActionResult MothWiseStudentReport()
        {
            var attendencelist = _saService.GetAll();
            var currentStudentAttendenceList = _adService.GetAll().Where(x => x.StudentId == User.GetUserId()).ToList();
            var studentReportList = new List<StudentMonthWiseDto>();
            foreach (var item in currentStudentAttendenceList)
            {

                var attendenceObj = attendencelist.FirstOrDefault(x => x.AttendanceId == item.AttendanceId);
                var model = new StudentMonthWiseDto();
                model.MonthId = attendenceObj.AttendanceDate.Month;
                model.MonthName = attendenceObj.AttendanceDate.ToString("MMMM");
                model.subjectName = _SubService.GetSingle(x => x.SubjectId == attendenceObj.SubjectId).SubjectName;
                model.subjectHeld += 1;
                model.StudentAttendence += item.IsPresent ? 1 : 0;
                model.Percent = 0;
                model.AttendenceId=attendenceObj.AttendanceId;
                studentReportList.Add(model);

            }

            return View(studentReportList);
        }

        [HttpGet]
        public IActionResult DayWiseStudentReport()
        {
            var attendencelist = _saService.GetAll();
            var currentStudentAttendenceList = _adService.GetAll().Where(x => x.StudentId == User.GetUserId()).ToList();
            var studentReportList = new List<DaywiseReportDto>();
            foreach (var item in currentStudentAttendenceList)
            {
                var attendenceObj = attendencelist.FirstOrDefault(x => x.AttendanceId == item.AttendanceId);
                var model = new DaywiseReportDto();
                model.AttendenceDate = attendenceObj.AttendanceDate;
                model.LectureId = attendenceObj.LectureId;
                model.subjectName = _SubService.GetSingle(x => x.SubjectId == attendenceObj.SubjectId).SubjectName;
                model.IsPresent = item.IsPresent;
                model.LectureName = _lectureService.GetById(attendenceObj.LectureId).LactureName;
                model.AttendenceId = item.AttendanceId;
                model.StudentId = item.StudentId;
                studentReportList.Add(model);

            }

            return View(studentReportList);
        }


        #region Common

        #endregion

    }
}
