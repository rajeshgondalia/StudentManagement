using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagement.Service.Dto
{
    public class StudentMonthWiseDto:BaseModel
    {
        public long MonthId { get; set; }
        public string MonthName { get; set; }

        public string subjectName { get; set; }

        public int subjectHeld { get; set; }

        public int StudentAttendence { get; set; }

        public decimal Percent { get; set; }
        public long AttendenceId { get; set; }

        public string StudentName { get; set; }

    }

    public class DaywiseReportDto
    {
        public DateTime  AttendenceDate { get; set; }

        public string subjectName { get; set; }

        public bool  IsPresent { get; set; }

        public long AttendenceId { get; set; }

        public string StudentName { get; set; }

        public long LectureId { get; set; }

        public string LectureName { get; set; }

        public long StudentId { get; set; }

    }

    
}
