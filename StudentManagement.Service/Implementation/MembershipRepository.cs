using StudentManagement.Service.Dto;
using StudentManagement.Service.Implementation.BaseService;
using StudentManagement.Service.Interface;
using StudentManagementAdmin.Data;
using StudentManagementAdmin.Data.DbModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Service.Implementation
{
    public class MembershipRepository : GenericRepository<Membership>, IMembershipService
    {
        private readonly StudentDbContext _context;

        public MembershipRepository(StudentDbContext context) : base(context)
        {
            _context = context;
        }

      
    }
}
