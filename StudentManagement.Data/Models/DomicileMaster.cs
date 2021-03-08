using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentManagement.Data.Models
{
    public class DomicileMaster:BaseModel
    {
        [Key]
        public long DomicileId { get; set; }
        public string Domicile { get; set; }

    }
}
