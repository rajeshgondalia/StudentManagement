using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagement.Service.Dto
{
    public class StudentProfileDto : BaseModel
    {

        public string Name { get; set; }
        public string OfficialEmail { get; set; }
        public string Mobile1 { get; set; }
        public string Mobile2 { get; set; }
        public string PersonalEmail1 { get; set; }
        public string PersonalEmail2 { get; set; }

        public DateTime Dob { get; set; }
        public string UserName { get; set; }

        public long CountryId { get; set; }
        public long CityId { get; set; }
        public long StateId { get; set; }
        public long ReligionId { get; set; }
        public long BloodGroupId { get; set; }
        public long CategoryId { get; set; }
        public long GenderId { get; set; }

        public long CampusId { get; set; }
        public long CollegeId { get; set; }
        public long CourseId { get; set; }
        public long BranchId { get; set; }
        public long YearSemId { get; set; }
        public long BatchId { get; set; }
        public long AdmissionBatchTypeId { get; set; }
        public long AdmissionTypeId { get; set; }
        public string CollegeRollNo { get; set; }
        public string UniversityEnrollmentNumber { get; set; }
        public string PassportNumber { get; set; }
        public string AdharNumber { get; set; }


        public long StayTypeId { get; set; }
        public string StayAddress { get; set; }
        public long StayRelationId { get; set; }

        public long StayCityId { get; set; }
        public long StayStateId { get; set; }
        public long StayCountryId { get; set; }
        public string StayPinCode { get; set; }


        public string FatherName { get; set; }
        public string FatherMobile1 { get; set; }
        public string FatherMobile2 { get; set; }
        public string FatherEmail { get; set; }
        public string FatherAddress { get; set; }

        public long FatherCityId { get; set; }
        public long FatherStateId { get; set; }
        public long FatherCountryId { get; set; }

        public string FatherPinCode { get; set; }

        public string MotherName { get; set; }
        public string MotherMobile1 { get; set; }
        public string MotherMobile2 { get; set; }
        public string MotherEmail { get; set; }
        public string MotherAddress { get; set; }

        public long MotherCityId { get; set; }
        public long MotherStateId { get; set; }
        public long MotherCountryId { get; set; }

        public string MotherPinCode { get; set; }

        public string LGName { get; set; }
        public string LGMobile1 { get; set; }
        public string LGMobile2 { get; set; }
        public string LGEmail { get; set; }
        public string LGAddress { get; set; }

        public long LGCityId { get; set; }
        public long LGStateId { get; set; }
        public long LGCountryId { get; set; }

        public string LGPinCode { get; set; }

        public long LGRelationId { get; set; }


        public bool IsEntrance { get; set; }
        public long EntranceExamId { get; set; }
        public int EntranceExamYear { get; set; }
        public string EntranceExamRollno { get; set; }
        public string EntranceExamMarkObt { get; set; }
        public string EntranceExamAir { get; set; }
        public string EntranceExamCatefgoryRank { get; set; }

        public IFormFile TenMarksheetPath { get; set; }
        public IFormFile TwelveMarksheetPath { get; set; }
        public IFormFile DiplomaMarksheetPath { get; set; }
        public IFormFile DegreeMarksheetPath { get; set; }
        public IFormFile PGMarksheetPath { get; set; }
        public IFormFile EntranceExamMasrksheetPath { get; set; }
        public IFormFile ColoredPhotograph { get; set; }
        public IFormFile CasteCertificate { get; set; }
        public IFormFile DomicileCertificate { get; set; }
        public IFormFile BirthCertificate { get; set; }
        public IFormFile Passport { get; set; }
        public IFormFile Adharcard { get; set; }


    }
}
