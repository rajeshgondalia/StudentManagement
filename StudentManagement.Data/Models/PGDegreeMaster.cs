using StudentManagementAdmin.Data.DbModel.BaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentManagement.Data.Models
{
    public class PGDegreeMaster : EntityWithAudit
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long PGDegreeId { get; set; }



        [Column(TypeName = "nvarchar(500)")]
        public string PGDegreeName { get; set; }
    }
}
