using StudentManagement.Data.DBContexts;
using StudentManagementAdmin.Data.DbModel.BaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentManagement.Data.Models
{
   public class ClassStudentDetail:EntityWithAudit
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ClassStudentId { get; set; }


        public long ClassId { get; set; }
        [ForeignKey("ClassId")]
        public virtual ClassMaster ClassMaster { get; set; }


        public long StudentId { get; set; }
        [ForeignKey("StudentId")]
        public virtual ApplicationUser ApplicationUser { get; set; }

    }
}
