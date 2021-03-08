using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentManagement.Data.Models
{
    public class TenPlusTwoMaster : BaseModel
    {
        [Key]
        public long TenMasterId { get; set; }
        public long TenPlusTwoMarkingId { get; set; }
        [ForeignKey("TenPlusTwoMarkingId")]
        public virtual MarkingSchemUGPGD MarkingSchemUGPGD { get; set; }

        public string BoardName { get; set; }

        public int YearOfPassing { get; set; }

        public string SchoolName { get; set; }

        public decimal CGPA { get; set; }
        public decimal PCMCGPA { get; set; }

    }
}