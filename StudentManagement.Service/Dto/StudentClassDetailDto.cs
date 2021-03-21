using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagement.Service.Dto
{
   public class StudentClassDetailDto:BaseModel
    {
        public string NameOfSubject { get; set; }
        public string TeacherName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
