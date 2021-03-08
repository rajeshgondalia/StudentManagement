using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagement.Service.Dto
{
   public class GradeDto:BaseModel
    {
        public string Name { get; set; }
        public List<LessonDto> lessonList { get; set; }
    }
}
