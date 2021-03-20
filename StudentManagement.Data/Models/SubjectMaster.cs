using StudentManagementAdmin.Data.DbModel.BaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentManagement.Data.Models
{
    public class SubjectMaster : EntityWithAudit
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long SubjectId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string SubjectName { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string SubjectCode { get; set; }

        public long SubjectTypeId { get; set; }
        [ForeignKey("SubjectTypeId")]
        public virtual SubjectTypeMaster  SubjectTypeMaster {get;set;}


        public long? SubjectDepartmentId { get; set; }
        [ForeignKey("SubjectDepartmentId")]
        public virtual SubjectDepartmentMaster SubjectDepartmentMaster { get; set; }

    }
}
