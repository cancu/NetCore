using System;
using System.Collections.Generic;
using System.Text;
using LifeIn2.Application.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LifeIn2.Persistence
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly NorthwindContext _context;
        private IUserRepository _user;
        private readonly ICategoryRepository _category;

        public EFUnitOfWork(NorthwindContext context)
        {
            _context = context;            
        }

        public void Commit()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }

            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
