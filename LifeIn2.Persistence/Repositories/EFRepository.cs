using LifeIn2.Application.Interfaces;
using LifeIn2.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LifeIn2.Persistence.Repositories
{
    public abstract class EFRepository<T> : IRepositoryBase<T> where T : class
    {
        protected NorthwindContext RepositoryContext { get; set; }

        public EFRepository(NorthwindContext repositoryContext)
        {
            this.RepositoryContext = repositoryContext;
        }

        public IEnumerable<T> GetAll()
        {
            return this.RepositoryContext.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await this.RepositoryContext.Set<T>().ToListAsync();
        }       

        public T GetById(int id)
        {
            return this.RepositoryContext.Set<T>().Find(id);
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await this.RepositoryContext.Set<T>().FindAsync(id);
        }

        public IEnumerable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return this.RepositoryContext.Set<T>().Where(predicate);
        }

        public async Task<IEnumerable<T>> GetAsync(Expression<Func<T, bool>> predicate)
        {
            return await this.RepositoryContext.Set<T>().Where(predicate).ToListAsync();
        }

        public void Update(T entity)
        {
            this.RepositoryContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            this.RepositoryContext.Set<T>().Remove(entity);
        }

        public void Add(T entity)
        {
            this.RepositoryContext.Set<T>().Add(entity);
        }

        public void Save()
        {
            this.RepositoryContext.SaveChanges();
        }

        public async Task SaveAsync()
        {
            await this.RepositoryContext.SaveChangesAsync();
        }   
    }
}
