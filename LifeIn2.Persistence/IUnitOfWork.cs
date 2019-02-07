using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LifeIn2.Persistence
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}
