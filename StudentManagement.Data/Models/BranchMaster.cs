using StudentManagementAdmin.Data.DbModel.BaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentManagement.Data.Models
{
   public  class BranchMaster:EntityWithAudit
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long BranchId { get; set; }
        

        public long CourseId { get; set; }
        [ForeignKey("CourseId")]
        public virtual CourseMaster CourseMaster { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string   Name { get; set; }
    }
}
