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

        
    }
}
