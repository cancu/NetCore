using System;
using System.Collections.Generic;
using System.Text;

namespace CancuNetCore.Domain.Entities.Security
{
    public class UserRole
    {
        public int UserRoleId { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
    }
}
