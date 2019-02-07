using LifeIn2.Application.Interfaces;
using LifeIn2.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace LifeIn2.Persistence.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {        
        private NorthwindContext _repoContext;
        private IUserRepository _user;
        private ICategoryRepository _category;

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

        public ICategoryRepository Category
        {
            get
            {
                if (_category == null)
                {
                    _category = new CategoryRepository(_repoContext);
                }
                return _category;
            }
        }
    }
}
