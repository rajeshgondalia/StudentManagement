using StudentManagement.Data.DBContexts;
using StudentManagement.Data.Models;
using StudentManagement.Service.Implementation.BaseService;
using StudentManagement.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagement.Service.Implementation
{
    public class RelationRepository : GenericRepository<RelationMaster>, IRelationService
    {
        private readonly StudentDbContext _db;
        public RelationRepository(StudentDbContext db) : base(db)
        {
            _db = db;
        }


    }
}