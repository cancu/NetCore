using CancuNetCore.Application.Interfaces;
using CancuNetCore.Domain.Entities.Security;
using CancuNetCore.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace CancuNetCore.Persistence.Repositories
{
    public class UserRepository : EFRepository<User>, IUserRepository
    {
        public UserRepository(NorthwindContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
