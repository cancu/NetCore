using System;
using System.Collections.Generic;
using System.Text;

namespace LifeIn2.Application.Repository
{
    public interface IRepositoryWrapper
    {
        IUserRepository User { get; }
    }
}
