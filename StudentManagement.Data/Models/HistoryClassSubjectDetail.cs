using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentManagement.Data.Models
{
  public  class HistoryClassSubjectDetail
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public long? CreatedBy { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }

        [DefaultValue(true)]
        public bool IsActive { get; set; }


        public long? ClassSubjectDetailId { get; set; }
        [ForeignKey("ClassSubjectDetailId")]
        public virtual ClassSubjectDetail ClassSubjectDetail { get; set; }

        public long? ClassId { get; set; }
        [ForeignKey("ClassId")]
        public virtual ClassMaster ClassMaster { get; set; }

        public long SubjectId { get; set; }
        public long L { get; set; }
        public long T { get; set; }
        public long P { get; set; }
        public long ESE { get; set; }
        public long CT { get; set; }
        public long TA { get; set; }
        public long Credit { get; set; }
        public long ActaulL { get; set; }

        public long SubjectDepartmentId { get; set; }
        public long StudentId { get; set; }
      

    }
}
