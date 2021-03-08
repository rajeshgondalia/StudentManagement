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
    public class TutorRepository: GenericRepository<Tutors>, ITutorService
    {
        private readonly StudentDbContext _context;

        public TutorRepository(StudentDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<TutorDto>> GetFilterTutorReport(SqlParameter[] paraObjects)
        {
            var dataSet = await _context.GetQueryDatatableAsync(SpConstants.GetTutorFilterReport, paraObjects);
            return Common.ConvertDataTable<TutorDto>(dataSet.Tables[0]);
        }
        public async Task<List<TutorDto>> GetTutorList(SqlParameter[] paraObjects)
        {
            var dataSet = await _context.GetQueryDatatableAsync(SpConstants.GetTutorList, paraObjects);
            return Common.ConvertDataTable<TutorDto>(dataSet.Tables[0]);
        }
        public async Task<List<TutorFilterLessionWiseAnswerDto>> GetCountWiseTutorReport(SqlParameter[] paraObjects)
        {
            var dataSet = await _context.GetQueryDatatableAsync(SpConstants.GetCountWiseTutorReport, paraObjects);
            return Common.ConvertDataTable<TutorFilterLessionWiseAnswerDto>(dataSet.Tables[0]);
        }
    }
}
