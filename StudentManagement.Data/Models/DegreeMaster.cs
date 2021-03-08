using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentManagement.Data.Models
{
  public  class DegreeMaster:BaseModel
    {
        [Key]
        public long DegreeId { get; set; }
        public string Name { get; set; }
        public int DegreeYear { get; set; }
        public long DegreeMarkingId { get; set; }
        [ForeignKey("DegreeMarkingId")]
        public virtual MarkingSchemUGPGD MarkingSchemUGPGD { get; set; }

        public decimal CGPA { get; set; }

        public string BoardName { get; set; }

    }
}
