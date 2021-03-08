using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentManagement.Data.Models
{
   public  class StateMaster:BaseModel
    {
        [Key]
        public long StateId { get; set; }

        public long CountryId { get; set; }
        [ForeignKey("CountryId")]
        public virtual CountryMaster CountryMaster { get; set; }

    }
}
