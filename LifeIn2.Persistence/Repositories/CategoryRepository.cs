using LifeIn2.Application.Interfaces;
using LifeIn2.Domain.Entities;
using LifeIn2.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace LifeIn2.Persistence.Repositories
{
    public class CategoryRepository : EFRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(NorthwindContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
