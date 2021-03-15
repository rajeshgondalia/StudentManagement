using StudentManagementAdmin.Data.DbModel.BaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentManagement.Data.Models
{
    public class HistoryClassMaster:EntityWithAudit
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public long ClassId { get; set; }
        public long SessionId { get; set; }
        public long CampusId { get; set; }
        public long CollegeId { get; set; }
        public long CourseId { get; set; }
        public long BranchId { get; set; }
        public long YearSemesterId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string ClassName { get; set; }

    }
}
