using StudentManagement.Data.DBContexts;
using StudentManagementAdmin.Data.DbModel.BaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentManagement.Data.Models
{
   public  class StudentRoleno:EntityWithAudit
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long RoleId { get; set; }


        [Column(TypeName = "bigint")]
        public long RoleNo { get; set; }

        public long UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }



    }
}
