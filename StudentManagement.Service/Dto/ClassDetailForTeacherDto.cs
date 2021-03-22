using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagement.Service.Dto
{
    public class ClassDetailForTeacherDto
    {
        public string RollNo { get; set; }
        public string StudentName { get; set; }
        public string ClassName { get; set; }
        public string SubjectName { get; set; }


        public string RollNoList { get; set; }
    }
}
