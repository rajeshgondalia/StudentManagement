using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentManagement.Data.Models
{
    public class HistoryStudentAttendanceDetail
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public long? CreatedBy { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }

        [DefaultValue(true)]
        public bool IsActive { get; set; }


        public long AttendanceDetail { get; set; }
        public long AttendanceId { get; set; }
        public long StudentId { get; set; }

        public bool IsPresent { get; set; }
    }
}
