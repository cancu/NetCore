﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LifeIn2.Domain.Security.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
