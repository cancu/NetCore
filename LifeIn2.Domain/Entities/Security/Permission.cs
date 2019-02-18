using System;
using System.Collections.Generic;
using System.Text;

namespace CancuNetCore.Domain.Entities.Security
{
    public class Permission
    {
        public int PermissionId { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
    }
}
