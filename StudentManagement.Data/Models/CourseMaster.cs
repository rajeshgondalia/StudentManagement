using StudentManagementAdmin.Data.DbModel.BaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentManagement.Data.Models
{
    public class CourseMaster : EntityWithAudit
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long CourseId { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string CourseName { get; set; }
    }
}
