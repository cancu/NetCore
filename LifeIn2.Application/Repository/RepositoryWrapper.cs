using LifeIn2.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace LifeIn2.Application.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {        
        private NorthwindContext _repoContext;
        private IUserRepository _user;

        public RepositoryWrapper(NorthwindContext context)
        {
            _repoContext = context;
        }

        public IUserRepository User
        {
            get
            {
                if(_user == null)
                {
                    _user = new UserRepository(_repoContext);
                }
                return _user;
            }
        }
    }
}
