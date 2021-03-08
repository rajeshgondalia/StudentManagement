using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentManagement.Data.Models
{
    public class AdmissiontypeMaster : BaseModel
    {
        [Key]
        public long AdmissiontypeId { get; set; }
        public string Admissiontype { get; set; }

    }
}
