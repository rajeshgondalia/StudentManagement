using StudentManagementAdmin.Data.DbModel.BaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentManagement.Data.Models
{
   public class SubjectDepartmentMaster:EntityWithAudit
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long SubjectDepartmentId { get; set; }


        [Column(TypeName = "nvarchar(200)")]
        public string Name { get; set; }
    }
}
