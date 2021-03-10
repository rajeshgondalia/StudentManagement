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


    }
}
