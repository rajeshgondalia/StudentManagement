using StudentManagement.Data.DBContexts;
using StudentManagementAdmin.Data.DbModel.BaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentManagement.Data.Models
{
   public  class StudentAttendance:EntityWithAudit
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long AttendanceId { get; set; }

        public long UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }

        public long ClassId { get; set; }
        [ForeignKey("ClassId")]
        public virtual ClassMaster ClassMaster { get; set; }

        public long SubjectId { get; set; }
        [ForeignKey("SubjectId")]
        public virtual SubjectMaster SubjectMaster { get; set; }

        public long LectureId { get; set; }
        [ForeignKey("LectureId")]
        public virtual LectureMaster LectureMaster { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime AttendanceDate { get; set; }


        [Column(TypeName = "bit")]
        public bool IsPresent { get; set; }

        public long? AttendanceBy { get; set; }
        [ForeignKey("AttendanceBy")]
        public virtual ApplicationUser ApplicationUser1 { get; set; }

    }
}
