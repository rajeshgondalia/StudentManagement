using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using StudentManagement.Data.DBContexts;
using StudentManagement.Service.Dto;
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
        private readonly IBloodGroupMasterService _bloodService;
        private readonly ICityMasterService _cityService;
        private readonly IStateMasterService _stateService;
        private readonly ICountryMasterService _countryService;
        private readonly IReligionMasterService _religionService;
        private readonly ICategoryMasterService _categoryService;
        private readonly IGenderService _genderService;
        private readonly UserManager<ApplicationUser> _userManager;

        #endregion

        #region Ctor
        public StudentProfileController(IPersonalDetailService personalDetailService,
            IBloodGroupMasterService bloodGroupMasterService,
            ICityMasterService cityMasterService,
            IStateMasterService stateMasterService,
            ICountryMasterService countryMasterService,
            IReligionMasterService religionMasterService,
            ICategoryMasterService categoryMasterService,
            UserManager<ApplicationUser> userManager,
            IGenderService genderService
            )
        {
            _personalDetailService = personalDetailService;
            _bloodService = bloodGroupMasterService;
            _cityService = cityMasterService;
            _stateService = stateMasterService;
            _countryService = countryMasterService;
            _religionService = religionMasterService;
            _categoryService = categoryMasterService;
            _genderService = genderService;
            _userManager = userManager;
        }

        #endregion
        #region Methods

        public async Task<IActionResult> Index()
        {
            BindDropdown();

            var userId = Convert.ToInt64(User.GetUserId());
            var userDetail =await _userManager.FindByIdAsync(userId.ToString());
            StudentProfileDto model = new StudentProfileDto();
            model.UserName = userDetail.UserName;
            model.Name = userDetail.Email;
            model.OfficialEmail = userDetail.OfficialEmail;

            var pd = _personalDetailService.GetSingle(x => x.UserId == userId);
            model.Mobile1 = pd.Mobile1;
            model.Mobile2 = pd.Mobile2;
            model.PersonalEmail1 = pd.PersonalEmail1;
            model.PersonalEmail2 = pd.PersonalEmail2;
            model.GenderId = pd.GenderId;
            model.CategoryId = pd.CategoryId;
            model.BloodGroupId = pd.BloodGroupdId;
            model.ReligionId = pd.ReligionId;
            model.CountryId = pd.CountryId;
            model.StateId = pd.StateId;
            model.Dob = pd.Dob;

            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> Updatestudent(StudentProfileDto model)
        {
            if (model != null)
            {
                var pd = _personalDetailService.GetSingle(x => x.UserId == User.GetUserId());
                if (pd != null)
                {
                    pd.Mobile1 = model.Mobile1;
                    pd.Mobile2 = model.Mobile2;
                    pd.PersonalEmail1 = model.PersonalEmail1;
                    pd.PersonalEmail2 = model.PersonalEmail2;
                    pd.GenderId = model.GenderId;
                    pd.CategoryId = model.CategoryId;
                    pd.BloodGroupdId = model.BloodGroupId;
                    pd.ReligionId = model.ReligionId;
                    pd.CountryId = model.CountryId;
                    pd.StateId = model.StateId;
                    pd.Dob = model.Dob;

                    var updateResult = await _personalDetailService.UpdateAsync(pd, Accessor, User.GetUserId());
                }
            }
            return RedirectToAction("Index");
        }
        #endregion
        #region Common

        public void BindDropdown()
        {
            ViewBag.CityList = _cityService.GetAll(x => x.IsActive == true).Select(x => new SelectListItem
            {
                Text = x.CityName,
                Value = x.CityId.ToString()
            }).OrderBy(x => x.Text).ToList();

            ViewBag.StateList = _stateService.GetAll(x => x.IsActive == true).Select(x => new SelectListItem
            {
                Text = x.StateName,
                Value = x.StateId.ToString()
            }).OrderBy(x => x.Text).ToList();

            ViewBag.CountryList = _countryService.GetAll(x => x.IsActive == true).Select(x => new SelectListItem
            {
                Text = x.CountryName,
                Value = x.CountryId.ToString()
            }).OrderBy(x => x.Text).ToList();

            ViewBag.BloodGroupList = _bloodService.GetAll(x => x.IsActive == true).Select(x => new SelectListItem
            {
                Text = x.Bloodgroup,
                Value = x.BloodgroupId.ToString()
            }).OrderBy(x => x.Text).ToList();

            ViewBag.ReligionList = _religionService.GetAll(x => x.IsActive == true).Select(x => new SelectListItem
            {
                Text = x.Religion,
                Value = x.ReligionId.ToString()
            }).OrderBy(x => x.Text).ToList();

            ViewBag.CategoryList = _categoryService.GetAll(x => x.IsActive == true).Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.CategoryId.ToString()
            }).OrderBy(x => x.Text).ToList();

            ViewBag.GenderList = _genderService.GetAll(x => x.IsActive == true).Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.GenId.ToString()
            }).OrderBy(x => x.Text).ToList();
        }
        #endregion


    }
}
