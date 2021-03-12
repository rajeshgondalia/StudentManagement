using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentManagement.Data.Models
{
   public class HistoryClassSubjectTeacherDetail
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public long? CreatedBy { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }

        [DefaultValue(true)]
        public bool IsActive { get; set; }

        public long? ClassSubjectTeacherId { get; set; }
        [ForeignKey("ClassSubjectDetailId")]
        public virtual ClassSubjectTeacherDetail ClassSubjectTeacherDetail { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string TeacherName { get; set; }

        public long TeacherId { get; set; }
    }
}
