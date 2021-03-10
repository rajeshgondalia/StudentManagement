using StudentManagementAdmin.Data.DbModel.BaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentManagement.Data.Models
{
 public   class StateMaster:EntityWithAudit
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long StateId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string StateName { get; set; }

        public long CountryId { get; set; }
        [ForeignKey("CountryId")]
        public virtual CountryMaster CountryMaster { get; set; }
    }
}
