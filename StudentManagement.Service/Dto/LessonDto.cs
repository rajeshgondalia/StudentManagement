using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagement.Service.Dto
{
    public class LessonDto : BaseModel
    {
        public string Name { get; set; }
        public string GradeName { get; set; }
        public long GradeId { get; set; }

        public string FileName { get; set; }
        public IFormFile  LessonFile { get; set; }
    }
}
