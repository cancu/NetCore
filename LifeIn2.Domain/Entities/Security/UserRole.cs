using System;
using System.Collections.Generic;
using System.Text;

namespace LifeIn2.Domain.Security.Entities
{
    public class UserRole
    {
        public int UserRoleId { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
    }
}
