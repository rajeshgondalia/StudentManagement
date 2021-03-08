using StudentManagementAdmin.Data.DbModel;
using StudentManagement.Service.Interface.BaseInterface;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using StudentManagement.Service.Dto;

namespace StudentManagement.Service.Interface
{
    public interface IGradeService : IGenericService<Grades>
    {
        Task<List<GradeDto>> GetGradeList(SqlParameter[] paraObjects);

    }
}
