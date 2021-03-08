using StudentManagement.Data.DBContexts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentManagement.Data.Models
{
   public  class CollegeDetail:BaseModel
    {
        [Key]
        public long CollegeDetailId { get; set; }

        public long StudentId { get; set; }
        [ForeignKey("StudentId")]
        public virtual ApplicationUser UserMaster { get; set; }

        public long CampusId { get; set; }
        [ForeignKey("CampusId")]
        public virtual CampusMaster CampusMaster { get; set; }

        public long CollegeId { get; set; }
        [ForeignKey("CollegeId")]
        public virtual CollegeMaster CollegeMaster { get; set; }

        public long CourseId { get; set; }
        [ForeignKey("CourseId")]
        public virtual CourseMaster CourseMaster { get; set; }

        public long BatchId { get; set; }
        [ForeignKey("BatchId")]
        public virtual BatchMaster BatchMaster { get; set; }

        public long branchId { get; set; }
        [ForeignKey("branchId")]
        public virtual BranchMaster BranchMaster { get; set; }

        public int Year { get; set; }

        public long AdmissionTypeId { get; set; }
        [ForeignKey("AdmissionTypeId")]
        public virtual AdmissiontypeMaster AdmissiontypeMaster { get; set; }
        public long AdmissionBatchTypeId { get; set; }
        [ForeignKey("AdmissionBatchTypeId")]
        public virtual AdmissionbatchMaster AdmissionbatchMaster { get; set; }

        public string Universityenrollmentnumber { get; set; }
        public string PassportNumber { get; set; }
        public string AdharNumber { get; set; }
        public string CollegeRollNumber { get; set; }
    }
}
