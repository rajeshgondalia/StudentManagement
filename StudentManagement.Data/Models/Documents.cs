using StudentManagement.Data.DBContexts;
using StudentManagementAdmin.Data.DbModel.BaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentManagement.Data.Models
{
   public class Documents:EntityWithAudit
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long DocumentId { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string TenMarksheetPath { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string TwelveMarksheetPath { get; set; }


        [Column(TypeName = "nvarchar(200)")]
        public string DiplomaMarksheetPath { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string DegreeMarksheetPath { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string PGMarksheetPath { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string EntranceExamMasrksheetPath { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string ColoredPhotograph { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string CasteCertificate { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string DomicileCertificate { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string BirthCertificate { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string Passport { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string Adharcard { get; set; }

        
        public long   UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }


    }
}
