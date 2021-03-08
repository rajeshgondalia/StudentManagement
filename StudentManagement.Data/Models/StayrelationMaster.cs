using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentManagement.Data.Models
{
    public class StayrelationMaster:BaseModel
    {
        [Key]
        public long StayrelationId { get; set; }

        public string Stayrelation { get; set; }

    }
}
