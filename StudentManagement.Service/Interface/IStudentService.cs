using StudentManagement.Service.Dto;
using StudentManagement.Service.Interface.BaseInterface;
using StudentManagementAdmin.Data.DbModel;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Service.Interface
{
    public interface IStudentService : IGenericService<Students>
    {
        Task<List<StudentDto>> GetStudentList(SqlParameter[] paraObjects);

        Task<List<StudentDto>> GetFilterStudentList(SqlParameter[] paraObjects);

        Task<List<StudentFilterGradeWiseDto>> GetGradeWiseStudentFilter(SqlParameter[] paraObjects);
        Task<List<QAByGradeTS>> GetQAByGrade(SqlParameter[] paraObjects);

        Task<List<FriendsDto>> GetStudentInviteFriendList(SqlParameter[] paraObjects);

    }
}
