using StudentManagement.Data.DBContexts;
using StudentManagement.Data.Models;
using StudentManagement.Service.Implementation.BaseService;
using StudentManagement.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagement.Service.Implementation
{
  public  class StudentAttendanceRepository : GenericRepository<StudentAttendance>, IStudentAttendanceService
    {
        private readonly StudentDbContext _db;
        public StudentAttendanceRepository(StudentDbContext db) : base(db)
        {
            _db = db;
        }


    }
}