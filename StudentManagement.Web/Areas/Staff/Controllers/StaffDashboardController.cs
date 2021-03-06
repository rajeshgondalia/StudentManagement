using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.Web.Utility.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Web.Areas.Staff.Controllers
{
    [Area("Staff")]
    [Authorize(Roles="Staff")]    
    public class StaffDashboardController : BaseController<StaffDashboardController>
    {
        public IActionResult Index()
        {
            return View();
        }



    }
}
