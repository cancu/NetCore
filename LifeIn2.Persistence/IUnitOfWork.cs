using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CancuNetCore.Persistence
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}
