using StudentManagementAdmin.Data.DbModel.BaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentManagement.Data.Models
{
    public class HistoryStudentAttendance:EntityWithAudit
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public long? CreatedBy { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }

        [DefaultValue(true)]
        public bool IsActive { get; set; }


        public long AttendanceId { get; set; }
        public long ClassId { get; set; }
        public long SubjectId { get; set; }
        public long LectureNoId { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime AttendanceDate { get; set; }
        public long AttendanceBy { get; set; }




    }
}
