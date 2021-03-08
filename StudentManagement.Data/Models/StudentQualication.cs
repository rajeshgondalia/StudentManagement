using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentManagement.Data.Models
{
   public  class StudentQualication:BaseModel
    {
        [Key]
        public long StudentQualicationId { get; set; }
        public long? EntranceExamId { get; set; }
        [ForeignKey("EntranceExamId")]
        public virtual EntranceExamMaster EntranceExamMaster { get; set; }
        public long? DegreeId { get; set; }
        [ForeignKey("DegreeId")]
        public virtual DegreeMaster DegreeMaster { get; set; }
        public long? DiplomaId { get; set; }
        [ForeignKey("DiplomaId")]
        public virtual DiplomaMaster DiplomaMaster { get; set; }

        public long? TenId { get; set; }
        [ForeignKey("TenId")]
        public virtual TenMaster TenMaster { get; set; }

        public long? TenPlusTwoId { get; set; }
        [ForeignKey("TenPlusTwoId")]
        public virtual TenPlusTwoMaster TenPlusTwoMaster { get; set; }
    }
}
