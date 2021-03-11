using StudentManagement.Data.DBContexts;
using StudentManagement.Data.Models;
using StudentManagement.Service.Implementation.BaseService;
using StudentManagement.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagement.Service.Implementation
{
    public class DocumentRepository : GenericRepository<Documents>, IDocumentService
    {
        private readonly StudentDbContext _db;
        public DocumentRepository(StudentDbContext db) : base(db)
        {
            _db = db;
        }


    }
}