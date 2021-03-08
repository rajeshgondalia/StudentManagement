using StudentManagementAdmin.Data.DbModel;
using StudentManagement.Service.Interface.BaseInterface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using StudentManagement.Service.Dto;

namespace StudentManagement.Service.Interface
{
    public interface ILessonService : IGenericService<Lessons>
    {
        Task<List<LessonDto>> GetLessonList(SqlParameter[] paraObjects);
    }
}
