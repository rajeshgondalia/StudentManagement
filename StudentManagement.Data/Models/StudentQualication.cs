using StudentManagement.Data.DBContexts;
using StudentManagementAdmin.Data.DbModel.BaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentManagement.Data.Models
{
    public class StudentQualication:EntityWithAudit
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long StudentQualicationId { get; set; }

        public long UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }

        public long? DegreeId { get; set; }
        [ForeignKey("DegreeId")]
        public virtual DegreeMaster DegreeMaster { get; set; }

        public long? DiplomaId { get; set; }
        [ForeignKey("DiplomaId")]
        public virtual DiplomaMaster DiplomaMaster { get; set; }


        public long? TenMarkingScheameId { get; set; }
        [ForeignKey("TenMarkingScheameId")]
        public virtual MarkingScheame MarkingScheame1 { get; set; }

        [Column(TypeName = "nvarchar(300)")]
        public string TenBoardName { get; set; }

        [Column(TypeName = "int")]
        public int? TenYearOfPassing { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? TenCGPA { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string TenSchoolName { get; set; }

        public long? TwelveMakingScheameId { get; set; }
        [ForeignKey("TwelveMakingScheameId")]
        public virtual MarkingScheame MarkingScheame2 { get; set; }

        [Column(TypeName = "nvarchar(300)")]
        public string TwelveBoardName { get; set; }

        [Column(TypeName = "int")]
        public int? TwelveYearOfPassing { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? TwelveCGPA { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? TwelvePCM { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string TwelveSchoolName { get; set; }



        [Column(TypeName = "int")]
        public int? DiplomaYear { get; set; }


        public long? DiplomaMarkingScheameId { get; set; }
        [ForeignKey("DiplomaMarkingScheameId")]
        public virtual MarkingScheame MarkingScheame3 { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? DiplomaCGPA { get; set; }

        [Column(TypeName = "nvarchar(300)")]
        public string DiplomaBoardName { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string DiplomaSchoolName { get; set; }


        [Column(TypeName = "int")]
        public int? DegreeYear { get; set; }

        public long? DegreeMarkingScheameId { get; set; }
        [ForeignKey("DegreeMarkingScheameId")]
        public virtual MarkingScheame MarkingScheame4 { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? DegreeCGPA { get; set; }


        [Column(TypeName = "nvarchar(300)")]
        public string DegreeSchoolName { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string DegreeBoardName { get; set; }


        public long PGDegreeId { get; set; }
        [ForeignKey("PGDegreeId")]
        public virtual PGDegreeMaster PGDegreeMaster { get; set; }

        [Column(TypeName = "int")]
        public int? PGDegreeYear { get; set; }

        public long? PGDegreeMarkingScheameId { get; set; }
        [ForeignKey("PGDegreeMarkingScheameId")]
        public virtual MarkingScheame MarkingScheame5 { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? PGDegreeCGPA { get; set; }

        [Column(TypeName = "nvarchar(300)")]
        public string PGDegreeSchoolName { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string PGDegreeBoardName { get; set; }

        public long? EntranceExamId { get; set; }
        [ForeignKey("EntranceExamId")]
        public virtual EntranceExamMaster EntranceExamMaster { get; set; }


        [Column(TypeName = "bit")]
        public bool IsEntrance { get; set; }

        [Column(TypeName = "int")]
        public int? EntranceExamYear { get; set; }


        [Column(TypeName = "nvarchar(50)")]
        public string EntranceExamRollno { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string EntranceExamMarkObt { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string EntranceExamAir { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string EntranceExamCatefgoryRank { get; set; }


    }
}
