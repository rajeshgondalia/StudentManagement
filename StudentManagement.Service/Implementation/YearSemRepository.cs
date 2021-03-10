using StudentManagement.Data.DBContexts;
using StudentManagement.Data.Models;
using StudentManagement.Service.Implementation.BaseService;
using StudentManagement.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagement.Service.Implementation
{
    public class YearSemRepository : GenericRepository<YearSemesterMaster>, IYearSemesterMasterService
    {
        private readonly StudentDbContext _db;
        public YearSemRepository(StudentDbContext db) : base(db)
        {
            _db = db;
        }


    }
}
