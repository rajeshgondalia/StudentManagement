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
    public interface ITutorService : IGenericService<Tutors>
    {
        Task<List<TutorDto>> GetTutorList(SqlParameter[] paraObjects);

        Task<List<TutorDto>> GetFilterTutorReport(SqlParameter[] paraObjects);
        Task<List<TutorFilterLessionWiseAnswerDto>> GetCountWiseTutorReport(SqlParameter[] paraObjects);
    }
}
