using LifeIn2.Domain.Entities;
using LifeIn2.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace LifeIn2.Application.Repository
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(NorthwindContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
