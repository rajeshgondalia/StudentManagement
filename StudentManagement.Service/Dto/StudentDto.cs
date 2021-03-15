using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagement.Service.Dto
{
   public class StudentDto:BaseModel
    {
        public string CollegeRollNumber { get; set; }
        public string FirstName { get; set; }
        public bool isPresent { get; set; }
    }
}
