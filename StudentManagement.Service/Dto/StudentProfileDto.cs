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
    }
}
