using StudentManagement.Service.Dto;
using StudentManagement.Service.GlobalConstant;
using StudentManagement.Service.Implementation.BaseService;
using StudentManagement.Service.Interface;
using StudentManagementAdmin.Data;
using StudentManagementAdmin.Data.DbModel;
using StudentManagementAdmin.Data.Extensions;
using StudentManagementAdmin.Data.Utility;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Service.Implementation
{
  public  class QuestionRequestRepository : GenericRepository<QuestionRequest>, IQuestionRequestService
    {
        private readonly StudentDbContext _context;

        public QuestionRequestRepository(StudentDbContext context) : base(context)
        {
            _context = context;
        }
       
    }
}

   