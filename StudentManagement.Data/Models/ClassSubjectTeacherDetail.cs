using StudentManagementAdmin.Data.DbModel.BaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentManagement.Data.Models
{
    public class ClassSubjectTeacherDetail:EntityWithAudit
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ClassSubjectTeacherId { get; set; }

        public long? ClassSubjectDetailId { get; set; }
        [ForeignKey("ClassSubjectDetailId")]
        public virtual ClassSubjectDetail ClassSubjectDetail { get; set; }

        public long TeacherId { get; set; }




    }
}
