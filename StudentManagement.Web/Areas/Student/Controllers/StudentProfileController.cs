using EasyLearnerAdmin.Utility.Common;
using EasyLearnerAdmin.Utility.JqueryDataTable;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using StudentManagement.Data.DBContexts;
using StudentManagement.Data.Models;
using StudentManagement.Service.Dto;
using StudentManagement.Service.Exception;
using StudentManagement.Service.Interface;
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
        private readonly IEntranceExamService _entranceExamService;
        private readonly IStudentQualificationSerivce _sqService;
        private readonly IDocumentService _documentService;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IMarkingSchemeService _markingSchemeService;
        private readonly IDiplomaService _diplomaService;
        private readonly IDegreeService _degreeService;
        private readonly IPGDegreeService _pgdegreeService;
         

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
            IGenderService genderService,
            IEntranceExamService entranceExamService,
            IStudentQualificationSerivce sqService,
            IDocumentService documentService,
            SignInManager<ApplicationUser> signInManager,
            IMarkingSchemeService markingSchemeService,
            IDiplomaService diplomaService,
        IDegreeService degreeService,
            IPGDegreeService pgdegreeService
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
            _entranceExamService = entranceExamService;
            _sqService = sqService;
            _documentService = documentService;
            _signInManager = signInManager;
            _markingSchemeService = markingSchemeService;
            _diplomaService = diplomaService;
            _degreeService = degreeService;
            _pgdegreeService = pgdegreeService;
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
            model.BloodGroupId = pd.BloodGroupdId??0;
            model.ReligionId = pd.ReligionId;
            model.CountryId = pd.CountryId;
            model.StateId = pd.StateId;
            model.Dob = pd.Dob;

            //current address details
            model.StayTypeId = pd.StayTypeId??0;
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

            //entrance exam details
            var ee= _sqService.GetSingle(x => x.UserId == User.GetUserId());

            model.IsEntrance = ee.IsEntrance;
            model.EntranceExamAir = ee.EntranceExamAir;
            model.EntranceExamRollno = ee.EntranceExamRollno;
            model.EntranceExamYear = ee.EntranceExamYear??0;
            model.EntranceExamId = ee.EntranceExamId;
            model.EntranceExamMarkObt = ee.EntranceExamMarkObt;
            model.EntranceExamCatefgoryRank = ee.EntranceExamCatefgoryRank;

            model.DegreeId = ee.DegreeId??0;
            model.DiplomaId = ee.DiplomaId??0;
            model.TenMarkingScheameId = ee.TenMarkingScheameId??0;
            model.TenBoardName = ee.TenBoardName;
            model.TenYearOfPassing = ee.TenYearOfPassing??0;
            model.TenCGPA = ee.TenCGPA??0;
            model.TenSchoolName = ee.TenSchoolName;
            model.TwelveMakingScheameId = ee.TwelveMakingScheameId??0;
            model.TwelveBoardName = ee.TwelveBoardName;
            model.TwelveYearOfPassing = ee.TwelveYearOfPassing??0;
            model.TwelveCGPA = ee.TwelveCGPA??0;
            model.TwelvePCM = ee.TwelvePCM??0;
            model.TwelveSchoolName = ee.TwelveSchoolName;
            model.DiplomaYear = ee.DiplomaYear??0;
            model.DiplomaMarkingScheameId = ee.DiplomaMarkingScheameId ?? 0;
            model.DiplomaCGPA = ee.DiplomaCGPA ?? 0;
            model.DiplomaBoardName = ee.DiplomaBoardName;
            model.DiplomaSchoolName = ee.DiplomaSchoolName;
            model.DegreeYear = ee.DegreeYear ?? 0;
            model.DegreeMarkingScheameId = ee.DegreeMarkingScheameId ?? 0;
            model.DegreeCGPA = ee.DegreeCGPA ?? 0;
            model.DegreeSchoolName = ee.DegreeSchoolName;
            model.DegreeBoardName = ee.DegreeBoardName;
            model.PGDegreeId = ee.PGDegreeId;
            model.PGDegreeYear = ee.PGDegreeYear??0;
            model.PGDegreeMarkingScheameId = ee.PGDegreeMarkingScheameId??0;
            model.PGDegreeCGPA = ee.PGDegreeCGPA??0;
            model.PGDegreeSchoolName = ee.PGDegreeSchoolName;
            model.PGDegreeBoardName = ee.PGDegreeBoardName;


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

        [HttpPost]
        public async Task<IActionResult> UpdateEntranceExamDetail(StudentProfileDto model)
        {
            if (model != null)
            {

                var pd = _sqService.GetSingle(x => x.UserId == User.GetUserId());
                if (pd != null)
                {
                    pd.IsEntrance = model.IsEntrance;
                    pd.EntranceExamAir = model.EntranceExamAir;
                    pd.EntranceExamRollno = model.EntranceExamRollno;
                    pd.EntranceExamYear = model.EntranceExamYear;
                    pd.EntranceExamId = model.EntranceExamId;
                    pd.EntranceExamMarkObt = model.EntranceExamMarkObt;
                    pd.EntranceExamCatefgoryRank = model.EntranceExamCatefgoryRank;


                    var updateResult = await _sqService.UpdateAsync(pd, Accessor, User.GetUserId());

                }

                return RedirectToAction("Index");

            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> UpdateQualificationDetail(StudentProfileDto model)
        {
            if (model != null)
            {

                try
                {
                    var pd = _sqService.GetSingle(x => x.UserId == User.GetUserId());
                    if (pd != null)
                    {
                        pd.DegreeId = model.DegreeId;
                        pd.DiplomaId = model.DiplomaId;
                        pd.TenMarkingScheameId = model.TenMarkingScheameId;
                        pd.TenBoardName = model.TenBoardName;
                        pd.TenYearOfPassing = model.TenYearOfPassing;
                        pd.TenCGPA = model.TenCGPA;
                        pd.TenSchoolName = model.TenSchoolName;
                        pd.TwelveMakingScheameId = model.TwelveMakingScheameId;
                        pd.TwelveBoardName = model.TwelveBoardName;
                        pd.TwelveYearOfPassing = model.TwelveYearOfPassing;
                        pd.TwelveCGPA = model.TwelveCGPA;
                        pd.TwelvePCM = model.TwelvePCM;
                        pd.TwelveSchoolName = model.TwelveSchoolName;
                        pd.DiplomaYear = model.DiplomaYear;
                        pd.DiplomaMarkingScheameId = model.DiplomaMarkingScheameId;
                        pd.DiplomaCGPA = model.DiplomaCGPA;
                        pd.DiplomaBoardName = model.DiplomaBoardName;
                        pd.DiplomaSchoolName = model.DiplomaSchoolName;
                        pd.DegreeYear = model.DegreeYear;
                        pd.DegreeMarkingScheameId = model.DegreeMarkingScheameId;
                        pd.DegreeCGPA = model.DegreeCGPA;
                        pd.DegreeSchoolName = model.DegreeSchoolName;
                        pd.DegreeBoardName = model.DegreeBoardName;
                        pd.PGDegreeId = model.PGDegreeId;
                        pd.PGDegreeYear = model.PGDegreeYear;
                        pd.PGDegreeMarkingScheameId = model.PGDegreeMarkingScheameId;
                        pd.PGDegreeCGPA = model.PGDegreeCGPA;
                        pd.PGDegreeSchoolName = model.PGDegreeSchoolName;
                        pd.PGDegreeBoardName = model.PGDegreeBoardName;


                        var updateResult = await _sqService.UpdateAsync(pd, Accessor, User.GetUserId());

                    }
                }
                catch (Exception e)
                {

                    return RedirectToAction("Index");
                }

                return RedirectToAction("Index");

            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> UpdateDocuments([FromForm]StudentProfileDto model)
        {
            using (var txscope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    if (model != null)
                    {
                        #region TenMarksheetPath
                        string TenMarksheetPath = string.Empty;
                        if (model.TenMarksheetPath != null)
                        {
                            TenMarksheetPath = User.GetUserId() + CommonMethod.GetFileName(model.TenMarksheetPath.FileName);
                            await CommonMethod.UploadFileAsync(HostingEnvironment.WebRootPath, FilePathListConstant.TenMarksheetPath, TenMarksheetPath, model.TenMarksheetPath);

                        }
                        #endregion

                        #region TwelveMarksheetPath
                        string TwelveMarksheetPath = string.Empty;
                        if (model.TwelveMarksheetPath != null)
                        {
                            TwelveMarksheetPath = User.GetUserId() + CommonMethod.GetFileName(model.TwelveMarksheetPath.FileName);
                            await CommonMethod.UploadFileAsync(HostingEnvironment.WebRootPath, FilePathListConstant.TwelveMarksheetPath, TwelveMarksheetPath, model.TwelveMarksheetPath);

                        }
                        #endregion

                        #region DiplomaMarksheetPath
                        string DiplomaMarksheetPath = string.Empty;
                        if (model.DiplomaMarksheetPath != null)
                        {
                            DiplomaMarksheetPath = User.GetUserId() + CommonMethod.GetFileName(model.DiplomaMarksheetPath.FileName);
                            await CommonMethod.UploadFileAsync(HostingEnvironment.WebRootPath, FilePathListConstant.DiplomaMarksheetPath, DiplomaMarksheetPath, model.DiplomaMarksheetPath);

                        }
                        #endregion

                        #region DegreeMarksheetPath
                        string DegreeMarksheetPath = string.Empty;
                        if (model.DegreeMarksheetPath != null)
                        {
                            DegreeMarksheetPath = User.GetUserId() + CommonMethod.GetFileName(model.DegreeMarksheetPath.FileName);
                            await CommonMethod.UploadFileAsync(HostingEnvironment.WebRootPath, FilePathListConstant.TenMarksheetPath, DegreeMarksheetPath, model.DegreeMarksheetPath);

                        }
                        #endregion

                        #region PGMarksheetPath
                        string PGMarksheetPath = string.Empty;
                        if (model.PGMarksheetPath != null)
                        {
                            PGMarksheetPath = User.GetUserId() + CommonMethod.GetFileName(model.PGMarksheetPath.FileName);
                            await CommonMethod.UploadFileAsync(HostingEnvironment.WebRootPath, FilePathListConstant.TenMarksheetPath, PGMarksheetPath, model.PGMarksheetPath);

                        }
                        #endregion

                        #region EntranceExamMasrksheetPath
                        string EntranceExamMasrksheetPath = string.Empty;
                        if (model.EntranceExamMasrksheetPath != null)
                        {
                            EntranceExamMasrksheetPath = User.GetUserId() + CommonMethod.GetFileName(model.EntranceExamMasrksheetPath.FileName);
                            await CommonMethod.UploadFileAsync(HostingEnvironment.WebRootPath, FilePathListConstant.EntranceExamMasrksheetPath, EntranceExamMasrksheetPath, model.EntranceExamMasrksheetPath);

                        }
                        #endregion

                        #region ColoredPhotograph
                        string ColoredPhotograph = string.Empty;
                        if (model.ColoredPhotograph != null)
                        {
                            ColoredPhotograph = User.GetUserId() + CommonMethod.GetFileName(model.ColoredPhotograph.FileName);
                            await CommonMethod.UploadFileAsync(HostingEnvironment.WebRootPath, FilePathListConstant.ColoredPhotograph, ColoredPhotograph, model.ColoredPhotograph);

                        }
                        #endregion

                        #region CasteCertificate
                        string CasteCertificate = string.Empty;
                        if (model.CasteCertificate != null)
                        {
                            CasteCertificate = User.GetUserId() + CommonMethod.GetFileName(model.CasteCertificate.FileName);
                            await CommonMethod.UploadFileAsync(HostingEnvironment.WebRootPath, FilePathListConstant.CasteCertificate, CasteCertificate, model.CasteCertificate);

                        }
                        #endregion

                        #region DomicileCertificate
                        string DomicileCertificate = string.Empty;
                        if (model.CasteCertificate != null)
                        {
                            DomicileCertificate = User.GetUserId() + CommonMethod.GetFileName(model.DomicileCertificate.FileName);
                            await CommonMethod.UploadFileAsync(HostingEnvironment.WebRootPath, FilePathListConstant.DomicileCertificate, DomicileCertificate, model.DomicileCertificate);

                        }
                        #endregion

                        #region BirthCertificate
                        string BirthCertificate = string.Empty;
                        if (model.BirthCertificate != null)
                        {
                            CasteCertificate = User.GetUserId() + CommonMethod.GetFileName(model.BirthCertificate.FileName);
                            await CommonMethod.UploadFileAsync(HostingEnvironment.WebRootPath, FilePathListConstant.BirthCertificate, BirthCertificate, model.BirthCertificate);

                        }
                        #endregion

                        #region Passport
                        string Passport = string.Empty;
                        if (model.Passport != null)
                        {
                            Passport = User.GetUserId() + CommonMethod.GetFileName(model.Passport.FileName);
                            await CommonMethod.UploadFileAsync(HostingEnvironment.WebRootPath, FilePathListConstant.Passport, Passport, model.Passport);

                        }
                        #endregion

                        #region Adharcard
                        string Adharcard = string.Empty;
                        if (model.Adharcard != null)
                        {
                            Adharcard = User.GetUserId() + CommonMethod.GetFileName(model.Adharcard.FileName);
                            await CommonMethod.UploadFileAsync(HostingEnvironment.WebRootPath, FilePathListConstant.Adharcard, Adharcard, model.Adharcard);

                        }
                        #endregion

                        var pd = _documentService.GetSingle(x => x.UserId == User.GetUserId());
                        if (pd != null)
                        {
                            pd.TenMarksheetPath = TenMarksheetPath;
                            pd.TwelveMarksheetPath = TwelveMarksheetPath;
                            pd.DiplomaMarksheetPath = DiplomaMarksheetPath;
                            pd.DegreeMarksheetPath = DegreeMarksheetPath;
                            pd.PGMarksheetPath = PGMarksheetPath;
                            pd.EntranceExamMasrksheetPath = EntranceExamMasrksheetPath;
                            pd.ColoredPhotograph = ColoredPhotograph;
                            pd.CasteCertificate = CasteCertificate;
                            pd.DomicileCertificate = DomicileCertificate;
                            pd.BirthCertificate = BirthCertificate;
                            pd.Passport = Passport;
                            pd.Adharcard = Adharcard;
                            pd.IsActive = true;

                            var updateResult = await _documentService.UpdateAsync(pd, Accessor, User.GetUserId());

                        }
                        else
                        {
                            var npd = new Documents();
                            npd.TenMarksheetPath = TenMarksheetPath;
                            npd.TwelveMarksheetPath = TwelveMarksheetPath;
                            npd.DiplomaMarksheetPath = DiplomaMarksheetPath;
                            npd.DegreeMarksheetPath = DegreeMarksheetPath;
                            npd.PGMarksheetPath = PGMarksheetPath;
                            npd.EntranceExamMasrksheetPath = EntranceExamMasrksheetPath;
                            npd.ColoredPhotograph = ColoredPhotograph;
                            npd.CasteCertificate = CasteCertificate;
                            npd.DomicileCertificate = DomicileCertificate;
                            npd.BirthCertificate = BirthCertificate;
                            npd.Passport = Passport;
                            npd.Adharcard = Adharcard;
                            npd.IsActive = true;
                            npd.UserId = User.GetUserId();

                            var inserResult = _documentService.InsertAsync(npd, Accessor, User.GetUserId());
                        }

                        txscope.Complete();
                        return JsonResponse.GenerateJsonResult(1, ResponseConstants.UpdatedRecord);

                    }
                    txscope.Complete();
                    return JsonResponse.GenerateJsonResult(1, ResponseConstants.UpdatedRecord);
                

                }
                catch (Exception ex)
            {
                txscope.Dispose();
                ErrorLog.AddErrorLog(ex, "UpdateDocuments");
                return JsonResponse.GenerateJsonResult(0, ResponseConstants.SomethingWrong);
            }
        }

        
        }



        public async Task<IActionResult> Logout()
        {
            
            await _signInManager.SignOutAsync();
            return RedirectToAction("index");
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
            ViewBag.MarkingSchemeList = _markingSchemeService.GetAll(x => x.IsActive == true).Select(x => new SelectListItem
            {
                Text = x.MarkingShchem,
                Value = x.MarkingShchemId.ToString()
            }).OrderBy(x => x.Text).ToList();

            ViewBag.DiplomaList = _diplomaService.GetAll(x => x.IsActive == true).Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.DiplomaId.ToString()
            }).OrderBy(x => x.Text).ToList();

            ViewBag.DegreeList = _degreeService.GetAll(x => x.IsActive == true).Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.DegreeId.ToString()
            }).OrderBy(x => x.Text).ToList();

            ViewBag.PGDegreeList = _pgdegreeService.GetAll(x => x.IsActive == true).Select(x => new SelectListItem
            {
                Text = x.PGDegreeName,
                Value = x.PGDegreeId.ToString()
            }).OrderBy(x => x.Text).ToList();

        }
        #endregion


    }
}
