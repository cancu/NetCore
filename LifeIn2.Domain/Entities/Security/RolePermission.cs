using System;
using System.Collections.Generic;
using System.Text;

namespace CancuNetCore.Domain.Entities.Security
{
    public class RolePermission
    {
        public int RolePermissionId { get; set; }
        public int RoleId { get; set; }
        public int PermissionId { get; set; }
    }
}
