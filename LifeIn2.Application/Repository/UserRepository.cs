using LifeIn2.Domain.Entities.Security;
using LifeIn2.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace LifeIn2.Application.Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(NorthwindContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
