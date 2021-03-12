using StudentManagementAdmin.Data.DbModel.BaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentManagement.Data.Models
{
   public  class StudentAttendanceDetail:EntityWithAudit
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long AttendanceDetailId { get; set; }

        public long AttendanceId { get; set; }
        public long StudentId { get; set; }
        public bool IsPresent { get; set; }

        
    }
}
