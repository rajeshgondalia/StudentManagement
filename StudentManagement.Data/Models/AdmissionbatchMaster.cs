using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentManagement.Data.Models
{
    public class AdmissionbatchMaster:BaseModel
    {
        [Key]
        public long AdmissionbatchId { get; set; }

        [StringLength(50)]
        public string Admissionbatch { get; set; }
    }
}
