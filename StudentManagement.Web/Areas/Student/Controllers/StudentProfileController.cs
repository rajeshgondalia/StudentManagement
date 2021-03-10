using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.Service.Exception;
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
    public class StudentProfileController : BaseController<StudentProfileController>
    {

        #region Fields

        private readonly IPersonalDetailService _personalDetailService;

        #endregion

        #region Ctor
        public StudentProfileController(IPersonalDetailService personalDetailService)
        {
            _personalDetailService = personalDetailService;
        }

        #endregion
        #region Methods

        public IActionResult Index()
        {
            //var userId = Convert.ToInt64(User.GetUserId());
            return View();
        }

        #endregion
        #region Common
        #endregion


    }
}
