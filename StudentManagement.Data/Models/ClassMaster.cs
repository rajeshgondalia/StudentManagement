using StudentManagementAdmin.Data.DbModel.BaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentManagement.Data.Models
{
    public class ClassMaster:EntityWithAudit
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ClassId { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string ClassName { get; set; }

        public long CampusId { get; set; }
        [ForeignKey("CampusId")]
        public virtual CampusMaster CampusMaster { get; set; }

        public long? CollegeId { get; set; }
        [ForeignKey("CollegeId")]
        public virtual CollegeMaster CollegeMaster { get; set; }

        public long? CourseId { get; set; }
        [ForeignKey("CourseId")]
        public virtual CourseMaster CourseMaster { get; set; }

        public long? BranchId { get; set; }
        [ForeignKey("BranchId")]
        public virtual BranchMaster BranchMaster { get; set; }

        public long? YearSemesterId { get; set; }
        [ForeignKey("YearSemesterId")]
        public virtual YearSemesterMaster YearSemesterMaster { get; set; }


        public long SessionId { get; set; }
        [ForeignKey("SessionId")]
        public virtual SessionMaster SessionMaster { get; set; }

    }
}
