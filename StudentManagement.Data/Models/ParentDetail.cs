using StudentManagement.Data.DBContexts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentManagement.Data.Models
{
   public class ParentDetail
    {
        [Key]
        public long StudentId { get; set; }
        [ForeignKey("StudentId")]
        public virtual ApplicationUser UserMaster { get; set; }

        public string FatherName { get; set; }
        public string FatherMobile1 { get; set; }
        public string FatherMobile2 { get; set; }
        public string FatherEmail { get; set; }
        public string FatherAddress { get; set; }

        public long? FatherCityId { get; set; }
        [ForeignKey("FatherCityId")]
        public virtual CityMaster FatherCityMaster { get; set; }

        public long? FatherStateId { get; set; }
        [ForeignKey("FatherStateId")]
        public virtual StateMaster FatherStateMaster { get; set; }

        public long? FatherCountryId { get; set; }
        [ForeignKey("FatherCountryId")]
        public virtual CountryMaster FatherCountryMaster { get; set; }



        public string MotherName { get; set; }
        public string MotherMobile1 { get; set; }
        public string MotherMobile2 { get; set; }
        public string MotherEmail { get; set; }
        public string MotherAddress { get; set; }

        public long? MotherCityId { get; set; }
        [ForeignKey("MotherCityId")]
        public virtual CityMaster MotherCityMaster { get; set; }

        public long? MotherStateId { get; set; }
        [ForeignKey("MotherStateId")]
        public virtual StateMaster MotherStateMaster { get; set; }

        public long? MotherCountryId { get; set; }
        [ForeignKey("MotherCountryId")]
        public virtual CountryMaster MotherCountryMaster { get; set; }


        public string LGName { get; set; }
        public string LGMobile1 { get; set; }
        public string LGMobile2 { get; set; }
        public string LGEmail { get; set; }
        public string LGAddress { get; set; }

        public long? LGCityId { get; set; }
        [ForeignKey("LGCityId")]
        public virtual CityMaster LGCityMaster { get; set; }

        public long? LGStateId { get; set; }
        [ForeignKey("LGStateId")]
        public virtual StateMaster LGStateMaster { get; set; }

        public long? LGCountryId { get; set; }
        [ForeignKey("LGCountryId")]
        public virtual CountryMaster LGCountryMaster { get; set; }


    }
}
