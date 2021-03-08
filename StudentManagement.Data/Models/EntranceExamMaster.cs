using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentManagement.Data.Models
{
    public class EntranceExamMaster : BaseModel
    {
        [Key]
        public long EntranceExamId { get; set; }
        public long ExamTypeId { get; set; }
        [ForeignKey("ExamTypeId")]
        public virtual ExamTypeMaster ExamTypeMaster { get; set; }

        public int ExamYear { get; set; }
        public string RollNumber { get; set; }
        public int MarkObtained { get; set; }
        public string ExamAir { get; set; }
        public int ExamCategoryRank { get; set; }
    }
}
