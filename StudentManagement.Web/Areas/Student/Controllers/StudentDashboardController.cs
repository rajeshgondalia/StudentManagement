using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.Web.Utility.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Web.Areas.Student.Controllers
{
    [Area("Student")]
    [Authorize(Roles= "Student")]
    public class StudentDashboardController : BaseController<StudentDashboardController>
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
