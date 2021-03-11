using StudentManagement.Data.DBContexts;
using StudentManagement.Data.Models;
using StudentManagement.Service.Implementation.BaseService;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagement.Service.Implementation
{
 public   class MarkingSchemeRepository : GenericRepository<MarkingScheame>, IMarkingSchemeService
    {
        private readonly StudentDbContext _db;
        public MarkingSchemeRepository(StudentDbContext db) : base(db)
        {
            _db = db;
        }


    }
}