
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
    public class StudentRepository : GenericRepository<Students>, IStudentService
    {
        private readonly StudentDbContext _context;

        public StudentRepository(StudentDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task<List<StudentDto>> GetStudentList(SqlParameter[] paraObjects)
        {
            var dataSet = await _context.GetQueryDatatableAsync(SpConstants.GetStudentList, paraObjects);
            return Common.ConvertDataTable<StudentDto>(dataSet.Tables[0]);
        }
        public async Task<List<FriendsDto>> GetStudentInviteFriendList(SqlParameter[] paraObjects)
        {
            var dataSet = await _context.GetQueryDatatableAsync(SpConstants.GetStudentFriendList, paraObjects);
            return Common.ConvertDataTable<FriendsDto>(dataSet.Tables[0]);
        }


        public async Task<List<StudentDto>> GetFilterStudentList(SqlParameter[] paraObjects)
        {
            var dataSet = await _context.GetQueryDatatableAsync(SpConstants.FilterStudent, paraObjects);
            return Common.ConvertDataTable<StudentDto>(dataSet.Tables[0]);
        }


        public async Task<List<StudentDto>> GetFriendsListGradewise(SqlParameter[] paraObjects)
        {
            var dataSet = await _context.GetQueryDatatableAsync(SpConstants.FilterStudent, paraObjects);
            return Common.ConvertDataTable<StudentDto>(dataSet.Tables[0]);
        }

        public async Task<List<StudentFilterGradeWiseDto>> GetGradeWiseStudentFilter(SqlParameter[] paraObjects)
        {
            var dataSet = await _context.GetQueryDatatableAsync(SpConstants.GetFriendsListGradewise, paraObjects);
            return Common.ConvertDataTable<StudentFilterGradeWiseDto>(dataSet.Tables[0]);
        }
        public async Task<List<QAByGradeTS>> GetQAByGrade(SqlParameter[] paraObjects)
        {
            var dataSet = await _context.GetQueryDatatableAsync(SpConstants.GetCountQAGradeReports, paraObjects);
            return Common.ConvertDataTable<QAByGradeTS>(dataSet.Tables[0]);
        }
    }
}
