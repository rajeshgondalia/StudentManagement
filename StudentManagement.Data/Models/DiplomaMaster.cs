using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentManagement.Data.Models
{
    public class DiplomaMaster:BaseModel
    {
        [Key]
        public long DiplomaId { get; set; }
        public string Name { get; set; }

        public int DiplomaYear { get; set; }
        public long DiplomaMarkingId { get; set; }
        [ForeignKey("DiplomaMarkingId")]
        public virtual MarkingSchemUGPGD MarkingSchemUGPGD { get; set; }

        public decimal CGPA { get; set; }

        public string BoardName { get; set; }



    }
}
