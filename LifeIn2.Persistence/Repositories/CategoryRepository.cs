using CancuNetCore.Application.Interfaces;
using CancuNetCore.Domain.Entities;
using CancuNetCore.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace CancuNetCore.Persistence.Repositories
{
    public class CategoryRepository : EFRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(NorthwindContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
