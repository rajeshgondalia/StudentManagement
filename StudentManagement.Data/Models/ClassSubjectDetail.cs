using StudentManagement.Data.DBContexts;
using StudentManagementAdmin.Data.DbModel.BaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentManagement.Data.Models
{
    public class ClassSubjectDetail:EntityWithAudit
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ClassSubjectDetailId { get; set; }

        public long ClassId { get; set; }
        [ForeignKey("ClassId")]
        public virtual ClassMaster ClassMaster { get; set; }

        public long SubjectId { get; set; }
        [ForeignKey("SubjectId")]
        public virtual SubjectMaster SubjectMaster { get; set; }

        public long L { get; set; }
        public long T { get; set; }
        public long P { get; set; }
        public long ESE { get; set; }
        public long CT { get; set; }
        public long TA { get; set; }
        public long Credit { get; set; }
        public long ActaulL { get; set; }

        public long SubjectDepartmentId { get; set; }
        [ForeignKey("SubjectDepartmentId")]
        public virtual SubjectDepartmentMaster SubjectDepartmentMaster { get; set; }

        public long StudentId { get; set; }
        [ForeignKey("StudentId")]
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
