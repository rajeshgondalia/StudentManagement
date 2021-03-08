using StudentManagement.Service.Interface.BaseInterface;
using StudentManagementAdmin.Data.DbModel;
using System;
using System.Collections.Generic;
using System.Text;
using StudentManagement.Service.Dto;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

namespace StudentManagement.Service.Interface
{
    public interface IFriendsService : IGenericService<Friends>
    {
        Task<List<FriendsDto>> GetFriendsList(SqlParameter[] paraObjects);

    }
}
