using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagement.Service.Dto
{
  public  class StudentRollListDto:BaseModel
    {
        public long StudentId { get; set; }
        public string RollNumber { get; set; }

        public string StudentName { get; set; }

    }
}
