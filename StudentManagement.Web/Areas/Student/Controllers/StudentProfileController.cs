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
        private readonly ICampusMasterService _campusService;
        private readonly ICollegeMasterService _collegeService;
        private readonly ICourseMasterService _courseService;
        private readonly IBranchMasterService _branchService;
        private readonly IYearSemesterMasterService _yearsemService;
        private readonly IBatchMasterService _batchService;
        private readonly ICollegeDetailService _collegeDetailService;
        private readonly IAdmissionTypeMasterService _admissionTypeService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IStayTypeService _staytypeService;
        private readonly IRelationService _relationService;
        private readonly IParentdetailService _parentService;
         

        #endregion

        #region Ctor
        public StudentProfileController(IPersonalDetailService personalDetailService,
        IBloodGroupMasterService bloodGroupMasterService,
        ICityMasterService cityMasterService,
        IStateMasterService stateMasterService,
        ICountryMasterService countryMasterService,
        IReligionMasterService religionMasterService,
        ICategoryMasterService categoryMasterService,
        ICampusMasterService campusService,
        ICollegeMasterService collegeService,
        ICourseMasterService courseService,
        IBranchMasterService branchMasterService,
        IYearSemesterMasterService yearsemService,
        IBatchMasterService batchService,
        ICollegeDetailService collegeDetailService,
        IAdmissionTypeMasterService admissionTypeMasterService,
        IStayTypeService staytypeService,
        IRelationService relationService,
        IParentdetailService parentService,
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
            _campusService = campusService;
            _collegeService = collegeService;
            _courseService = courseService;
            _branchService = branchMasterService;
            _yearsemService = yearsemService;
            _batchService = batchService;
            _userManager = userManager;
            _collegeDetailService = collegeDetailService;
            _admissionTypeService = admissionTypeMasterService;
            _staytypeService = staytypeService;
            _relationService = relationService;
            _parentService = parentService;
        }

        #endregion
        #region Methods

        public async Task<IActionResult> Index()
        {
            BindDropdown();

            var userId = Convert.ToInt64(User.GetUserId());
            var userDetail = await _userManager.FindByIdAsync(userId.ToString());
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

            //current address details
            model.StayTypeId = pd.StayTypeId;
            model.StayAddress = pd.StayAddress;
            model.StayRelationId = pd.StayRelationId ?? 0;
            model.StayCityId = pd.StayCityId ?? 0;
            model.StayCountryId = pd.StayCountryId ?? 0;
            model.StayStateId = pd.StayStateId??0;
            model.StayPinCode = pd.StayPinCode;


            var cgDetail = _collegeDetailService.GetSingle(x => x.UserId == User.GetUserId());

            model.CampusId = cgDetail.CampusId;
            model.CollegeId = cgDetail.CollegeId;
            model.BranchId = cgDetail.branchId ?? 0;
            model.CourseId = cgDetail.CourseId;
            model.YearSemId = cgDetail.YearSemesterId;
            model.BatchId = cgDetail.BatchId;
            model.AdmissionBatchTypeId = cgDetail.AdmissionBatchTypeId ?? 0;
            model.AdmissionTypeId = cgDetail.AdmissionTypeId;
            model.CollegeRollNo = cgDetail.CollegeRollNumber;
            model.UniversityEnrollmentNumber = cgDetail.Universityenrollmentnumber;
            model.PassportNumber = cgDetail.PassportNumber;
            model.AdharNumber = cgDetail.AdharNumber;


            //ParentDetail
            var parent = _parentService.GetSingle(x => x.UserId == User.GetUserId());
            model.FatherName = parent.FatherName;
            model.FatherMobile1 = parent.FatherMobile1;
            model.FatherMobile2 = parent.FatherMobile2;
            model.FatherEmail = parent.FatherEmail;
            model.FatherAddress = parent.FatherAddress;
            model.FatherCityId = parent.FatherCityId??0;
            model.FatherStateId = parent.FatherStateId ?? 0;
            model.FatherCountryId = parent.FatherCountryId ?? 0;
            model.FatherPinCode = parent.FatherPincode;

            model.MotherName = parent.MotherName;
            model.MotherMobile1 = parent.MotherMobile1;
            model.MotherMobile2 = parent.MotherMobile2;
            model.MotherEmail = parent.MotherEmail;
            model.MotherAddress = parent.MotherAddress;
            model.MotherCityId = parent.MotherCityId??0;
            model.MotherStateId = parent.MotherStateId??0;
            model.MotherCountryId = parent.MotherCountryId??0;
            model.MotherPinCode = parent.MotherPincode;

            model.LGName = parent.LGName;
            model.LGMobile1 = parent.LGMobile1;
            model.LGMobile2 = parent.LGMobile2;
            model.LGEmail = parent.LGEmail;
            model.LGAddress = parent.LGAddress;
            model.LGCityId = parent.LGCityId??0;
            model.LGStateId = parent.LGStateId??0;
            model.LGCountryId = parent.LGCountryId??0;
            model.LGPinCode = parent.LGPincode;
            model.LGRelationId = parent.RelationId??0 ;


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

        [HttpPost]
        public async Task<IActionResult> UpdateCollegeDetail(StudentProfileDto model)
        {
            if (model != null)
            {
                var cd = _collegeDetailService.GetSingle(x => x.UserId == User.GetUserId());
                if (cd != null)
                {
                    cd.CampusId = model.CampusId;
                    cd.CollegeId = model.CollegeId;
                    cd.YearSemesterId = model.YearSemId;
                    cd.AdmissionTypeId = model.AdmissionTypeId;
                    cd.AdmissionBatchTypeId = model.AdmissionBatchTypeId;
                    cd.CollegeRollNumber = model.CollegeRollNo;
                    cd.Universityenrollmentnumber = model.UniversityEnrollmentNumber;
                    cd.PassportNumber = model.PassportNumber;
                    cd.AdharNumber = model.AdharNumber;

                    var updateResult = await _collegeDetailService.UpdateAsync(cd, Accessor, User.GetUserId());


                }
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> UpdateCurrentAddress(StudentProfileDto model)
        {
            if (model != null)
            {
               
                    var pd = _personalDetailService.GetSingle(x => x.UserId == User.GetUserId());
                    if (pd != null)
                    {
                        pd.StayTypeId = model.StayTypeId;
                        pd.StayAddress = model.StayAddress;
                        pd.StayRelationId = model.StayRelationId;
                        pd.StayCityId = model.StayCityId;
                        pd.StayCountryId = model.StayCountryId;
                        pd.StayStateId = model.StayStateId;
                        pd.StayPinCode = model.StayPinCode;


                        var updateResult = await _personalDetailService.UpdateAsync(pd, Accessor, User.GetUserId());

                    }
               
                return RedirectToAction("Index");
            
            }
            return RedirectToAction("Index");
        }



        [HttpPost]
        public async Task<IActionResult> UpdateParentDetail(StudentProfileDto model)
        {
            if (model != null)
            {

                var pd = _parentService.GetSingle(x => x.UserId == User.GetUserId());
                if (pd != null)
                {
                    pd.FatherName = model.FatherName;
                    pd.FatherMobile1 = model.FatherMobile1;
                    pd.FatherMobile2 = model.FatherMobile2;
                    pd.FatherEmail = model.FatherEmail;
                    pd.FatherAddress = model.FatherAddress;
                    pd.FatherCityId = model.FatherCityId;
                    pd.FatherStateId = model.FatherStateId;
                    pd.FatherCountryId = model.FatherCountryId;
                    pd.FatherPincode = model.FatherPinCode;

                    pd.MotherName = model.MotherName;
                    pd.MotherMobile1 = model.MotherMobile1;
                    pd.MotherMobile2 = model.MotherMobile2;
                    pd.MotherEmail = model.MotherEmail;
                    pd.MotherAddress = model.MotherAddress;
                    pd.MotherCityId = model.MotherCityId;
                    pd.MotherStateId = model.MotherStateId;
                    pd.MotherCountryId = model.MotherCountryId;
                    pd.MotherPincode = model.MotherPinCode;

                    pd.LGName = model.LGName;
                    pd.LGMobile1 = model.LGMobile1;
                    pd.LGMobile2 = model.LGMobile2;
                    pd.LGEmail = model.LGEmail;
                    pd.LGAddress = model.LGAddress;
                    pd.LGCityId = model.LGCityId;
                    pd.LGStateId = model.LGStateId;
                    pd.LGCountryId = model.LGCountryId;
                    pd.LGPincode = model.LGPinCode;
                    pd.RelationId = model.LGRelationId;


                    var updateResult = await _parentService.UpdateAsync(pd, Accessor, User.GetUserId());

                }

                return RedirectToAction("Index");

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


            ViewBag.CampusList = _campusService.GetAll(x => x.IsActive == true).Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.CampusId.ToString()
            }).OrderBy(x => x.Text).ToList();

            ViewBag.CollegeList = _collegeService.GetAll(x => x.IsActive == true).Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.CollegeId.ToString()
            }).OrderBy(x => x.Text).ToList();

            ViewBag.CourseList = _courseService.GetAll(x => x.IsActive == true).Select(x => new SelectListItem
            {
                Text = x.CourseName,
                Value = x.CourseId.ToString()
            }).OrderBy(x => x.Text).ToList();


            ViewBag.BranchList = _branchService.GetAll(x => x.IsActive == true).Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.BranchId.ToString()
            }).OrderBy(x => x.Text).ToList();


            ViewBag.YearSemList = _yearsemService.GetAll(x => x.IsActive == true).Select(x => new SelectListItem
            {
                Text = x.YearSemester,
                Value = x.YearSemesterId.ToString()
            }).OrderBy(x => x.Text).ToList();


            ViewBag.BatchList = _batchService.GetAll(x => x.IsActive == true).Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.BatchId.ToString()
            }).OrderBy(x => x.Text).ToList();

            ViewBag.AdmissionTypeList = _admissionTypeService.GetAll(x => x.IsActive == true).Select(x => new SelectListItem
            {
                Text = x.Admissiontype,
                Value = x.AdmissiontypeId.ToString()
            }).OrderBy(x => x.Text).ToList();

            ViewBag.StayTypeList = _staytypeService.GetAll(x => x.IsActive == true).Select(x => new SelectListItem
            {
                Text = x.Staytype,
                Value = x.StaytypeId.ToString()
            }).OrderBy(x => x.Text).ToList();

            ViewBag.RelationList = _relationService.GetAll(x => x.IsActive == true).Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.RelationId.ToString()
            }).OrderBy(x => x.Text).ToList();

        }
        #endregion


    }
}
