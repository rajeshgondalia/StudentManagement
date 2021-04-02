using StudentManagement.Data.DBContexts;
using StudentManagement.Data.Models;
using StudentManagement.Service.Implementation.BaseService;
using StudentManagement.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagement.Service.Implementation
{
   public class ClassSubjectTeacherDetailRepository : GenericRepository<ClassSubjectTeacherDetail>, IClassSubjectTeacherService
    {
        private readonly StudentDbContext _db;
        public ClassSubjectTeacherDetailRepository(StudentDbContext db) : base(db)
        {
            _db = db;
        }


    }
}