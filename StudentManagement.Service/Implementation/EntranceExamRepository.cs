using StudentManagement.Data.DBContexts;
using StudentManagement.Data.Models;
using StudentManagement.Service.Implementation.BaseService;
using StudentManagement.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagement.Service.Implementation
{
  public  class EntranceExamRepository : GenericRepository<EntranceExamMaster>, IEntranceExamService
    {
        private readonly StudentDbContext _db;
        public EntranceExamRepository(StudentDbContext db) : base(db)
        {
            _db = db;
        }


    }
}