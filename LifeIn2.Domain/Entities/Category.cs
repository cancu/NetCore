using System;
using System.Collections.Generic;

namespace CancuNetCore.Domain.Entities
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Products>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }

        public ICollection<Products> Products { get; set; }
    }
}
