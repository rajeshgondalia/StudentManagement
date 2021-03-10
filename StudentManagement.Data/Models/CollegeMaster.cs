using StudentManagementAdmin.Data.DbModel.BaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentManagement.Data.Models
{
 public   class CollegeMaster:EntityWithAudit
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long CollegeId { get; set; }


        public long CampusId { get; set; }
        [ForeignKey("CampusId")]
        public virtual CampusMaster CampusMaster { get; set; }


        [Column(TypeName = "nvarchar(max)")]
        public string Name { get; set; }

    }
}
