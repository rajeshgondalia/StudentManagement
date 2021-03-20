using StudentManagementAdmin.Data.DbModel.BaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentManagement.Data.Models
{
   public class CityMaster:EntityWithAudit
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long CityId { get; set; }

        
        [Column(TypeName = "nvarchar(100)")]
        public string CityName { get; set; }



        public long? StateId { get; set; }
        [ForeignKey("StateId")]
        public virtual StateMaster StateMaster { get; set; }

    }
}
