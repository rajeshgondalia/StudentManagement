using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentManagement.Data.Models
{
    public class MarkingSchemUGPGD:BaseModel
    {
        [Key]
        public long MarkingShchemId { get; set; }
        public string MarkingShchem { get; set; }

       
    }
}
