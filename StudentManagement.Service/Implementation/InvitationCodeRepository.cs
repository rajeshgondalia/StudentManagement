using StudentManagement.Service.Implementation.BaseService;
using StudentManagement.Service.Interface;
using StudentManagementAdmin.Data;
using StudentManagementAdmin.Data.DbModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagement.Service.Implementation
{
   public class InvitationCodeRepository : GenericRepository<InvitationCode>, IInvitationCodeService
    {
        private readonly StudentDbContext _context;
        public InvitationCodeRepository(StudentDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
