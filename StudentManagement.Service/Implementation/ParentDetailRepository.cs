using StudentManagement.Data.DBContexts;
using StudentManagement.Data.Models;
using StudentManagement.Service.Implementation.BaseService;
using StudentManagement.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagement.Service.Implementation
{
   public class ParentDetailRepository : GenericRepository<ParentDetail>, IParentdetailService
    {
        private readonly StudentDbContext _db;
        public ParentDetailRepository(StudentDbContext db) : base(db)
        {
            _db = db;
        }


    }
}