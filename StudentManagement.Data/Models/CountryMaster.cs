using StudentManagementAdmin.Data.DbModel.BaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentManagement.Data.Models
{
   public  class CountryMaster:EntityWithAudit
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long CountryId { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string CountryName { get; set; }
    }
}
