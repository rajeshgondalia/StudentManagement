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

    }

    
}
