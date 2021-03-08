using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentManagement.Data.Models
{
 public   class StudentAttendence
    {
        [Key]
        public long StudentAttendenceId { get; set; }

        public int Held { get; set; }
        public int Attendence { get; set; }

        public decimal  percent { get; set; }

        public string SubjectName { get; set; }

        public DateTime DateOfAttend { get; set; }

    }
}
