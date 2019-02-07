using LifeIn2.Application.Interfaces;
using LifeIn2.Domain.Entities.Security;
using LifeIn2.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace LifeIn2.Persistence.Repositories
{
    public class UserRepository : EFRepository<User>, IUserRepository
    {
        public UserRepository(NorthwindContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
