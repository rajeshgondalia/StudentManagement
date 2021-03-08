using StudentManagement.Data.DBContexts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentManagement.Data.Models
{
  public  class PersonalDetail:BaseModel
    {
        [Key]
        public long PersonalDetailId { get; set; }

        public long UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual ApplicationUser UserMaster { get; set; }
      
        public string Mobile1 { get; set; }
        public string Mobile2 { get; set; }
        public string PersonalEmail1 { get; set; }
        public string PersonalEmail2 { get; set; }

        public long GenderId { get; set; }
        [ForeignKey("GenderId")]
        public virtual GenderMaster Gender { get; set; }

        public DateTime Dob { get; set; }

        public long CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual CategoryMaster CategoryMaster { get; set; }


        public long BloodGroupdId { get; set; }
        [ForeignKey("BloodGroupdId")]
        public virtual BloodgroupMaster BloodgroupMaster { get; set; }


        public long ReligionId { get; set; }
        [ForeignKey("ReligionId")]
        public virtual ReligionMaster ReligionMaster { get; set; }

        public long NationalityId { get; set; }
        [ForeignKey("NationalityId")]
        public virtual NationalityMaster NationalityMaster { get; set; }


        public long DomicileId { get; set; }
        [ForeignKey("DomicileId")]
        public virtual DomicileMaster DomicileMaster { get; set; }


        public long? CityId { get; set; }
        [ForeignKey("CityId")]
        public virtual CityMaster CityMaster { get; set; }

        public long? StateId { get; set; }
        [ForeignKey("StateId")]
        public virtual StateMaster StateMaster { get; set; }


        public long? CountryId { get; set; }
        [ForeignKey("CountryId")]
        public virtual CountryMaster CountryMaster { get; set; }


        public long? StayTypeId { get; set; }
        [ForeignKey("StayTypeId")]
        public virtual StaytypeMaster StaytypeMaster { get; set; }


        public string StayAddress { get; set; }

        public long? StayRelationId { get; set; }
        [ForeignKey("StayRelationId")]
        public virtual StayrelationMaster Stayrelation { get; set; }


    }
}
