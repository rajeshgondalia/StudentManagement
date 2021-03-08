using StudentManagement.Service.Implementation.BaseService;
using StudentManagement.Service.Interface;
using StudentManagementAdmin.Data;
using StudentManagementAdmin.Data.DbModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagement.Service.Implementation
{
    public class ExamsLessonsRepository : GenericRepository<ExamLessons>, IExamLessonService
    {
        private readonly StudentDbContext _context;

        public ExamsLessonsRepository(StudentDbContext context) : base(context)
        {
            _context = context;
        }
    
    }
}
