using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagement.Service.Dto
{
   public class DaywiseAttendenceDto
    {
        public long LectureId { get; set; }

        public long AttendenceBy { get; set; }

        public DateTime AttendenceDate { get; set; }

        public string SubjectName { get; set; }

        public bool IsPresent { get; set; }

        public string LactureName { get; set; }
    }



}
