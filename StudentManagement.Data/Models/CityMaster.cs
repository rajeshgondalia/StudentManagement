using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentManagement.Data.Models
{
    public class CityMaster : BaseModel
    {
        [Key]
        public long CityId { get; set; }    

        public long StateId { get; set; }
        [ForeignKey("StateId")]
        public virtual StateMaster StateMaster {get;set;}

        public string PinCode { get; set; }
    }
}
