using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using StudentManagement.Service.Interface;
using StudentManagement.Web.Utility.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Web.Areas.Student.Controllers
{
    [Area("Student")]
    [Authorize(Roles = "Student")]
    public class StudentAttendenceController : BaseController<StudentAttendenceController>
    {
        #region Fields
        private readonly ILectureService _lectureService;

        #endregion

        #region Ctor
        public StudentAttendenceController(ILectureService lectureService)
        {
            _lectureService = lectureService;
        }

        #endregion

        #region Methods

        public IActionResult Index()
        {
         
         



            return View();
        }


       


        #endregion

        #region Common
        
        #endregion




    }
}
