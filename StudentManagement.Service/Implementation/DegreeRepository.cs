using StudentManagement.Data.DBContexts;
using StudentManagement.Data.Models;
using StudentManagement.Service.Implementation.BaseService;
using StudentManagement.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagement.Service.Implementation
{
   public class DegreeRepository : GenericRepository<DegreeMaster>, IDegreeService
    {
        private readonly StudentDbContext _db;
        public DegreeRepository(StudentDbContext db) : base(db)
        {
            _db = db;
        }


    }
}