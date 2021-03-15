using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagement.Service.Dto
{
   public class StudentAttendenceDto:BaseModel
    {
        public long ClassId { get; set; }
        public long SubjectId { get; set; }
        public long LectureId { get; set; }
        public DateTime AttendenceDate { get; set; }
        public bool IsMarkedPresent { get; set; }

        public List<StudentList> StudentList { get; set; }
    }

    public class StudentList
    {
        public long StudentId { get; set; }
        public string  RollNo { get; set; }
        public string Name { get; set; }
        public bool IsPresent { get; set; }

    }
}
