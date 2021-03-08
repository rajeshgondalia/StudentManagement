using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagement.Service.Dto
{
    public class InvitationCodeDto : BaseModel
    {
        public int NoOfFreeQuestions { get; set; }
        public int NoOfFreeDays { get; set; }
        public int ExpirationDays { get; set; }
    }
}
