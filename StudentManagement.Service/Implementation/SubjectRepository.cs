using StudentManagement.Data.DBContexts;
using StudentManagement.Data.Models;
using StudentManagement.Service.Implementation.BaseService;
using StudentManagement.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagement.Service.Implementation
{
  public  class SubjectRepository : GenericRepository<SubjectMaster>, ISubjectService
    {
        private readonly StudentDbContext _db;
        public SubjectRepository(StudentDbContext db) : base(db)
        {
            _db = db;
        }


    }
}