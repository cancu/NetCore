﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LifeIn2.Domain.Security.Entities
{
    public class RolePermission
    {
        public int RolePermissionId { get; set; }
        public int RoleId { get; set; }
        public int PermissionId { get; set; }
    }
}