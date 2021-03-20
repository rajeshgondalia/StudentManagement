using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagement.Service.Dto
{
    public class StaffAttendenceDto
    {
        public List<long> StudentIdList { get; set; }
        public long ClassId { get; set; }
        public long SubjectId { get; set; }
        public long LectureId { get; set; }
        public int Mark { get; set; }
        public string AttendenceDate { get; set; }
    }
}
