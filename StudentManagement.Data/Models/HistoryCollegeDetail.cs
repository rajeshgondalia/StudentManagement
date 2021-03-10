using StudentManagement.Data.DBContexts;
using StudentManagementAdmin.Data.DbModel.BaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentManagement.Data.Models
{
 public   class HistoryCollegeDetail:EntityWithAudit
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public long? CollegeDetailId { get; set; }
        [ForeignKey("CollegeDetailId")]
        public virtual CollegeDetail CollegeDetail { get; set; }

        public long UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }

        public long CampusId { get; set; }
        [ForeignKey("CampusId")]
        public virtual CampusMaster CampusMaster { get; set; }

        public long CollegeId { get; set; }
        

        public long CourseId { get; set; }
        [ForeignKey("CourseId")]
        public virtual CourseMaster CourseMaster { get; set; }

        public long BatchId { get; set; }
        [ForeignKey("BatchId")]
        public virtual BatchMaster BatchMaster { get; set; }

        public long? branchId { get; set; }
        [ForeignKey("branchId")]
        public virtual BranchMaster BranchMaster { get; set; }

        public long YearSemesterId { get; set; }
        [ForeignKey("YearSemesterId")]
        public virtual YearSemesterMaster YearSemesterMaster { get; set; }

        public long AdmissionTypeId { get; set; }
        [ForeignKey("AdmissionTypeId")]
        public virtual AdmissiontypeMaster AdmissiontypeMaster { get; set; }

        public long? AdmissionBatchTypeId { get; set; }
        [ForeignKey("AdmissionBatchTypeId")]
        public virtual BatchMaster BatchMaster1 { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string Universityenrollmentnumber { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string PassportNumber { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string AdharNumber { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string CollegeRollNumber { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string UniversityExamRoleNo { get; set; }
    }
}
