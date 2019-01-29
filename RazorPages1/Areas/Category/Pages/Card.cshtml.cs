using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages1.Common;
using LifeIn2.Persistence;
using LifeIn2.Domain;

namespace LifeIn2.RazorUI.Areas.Category.Pages
{
    public class CardModel : PageModel
    {
        NorthwindContext _context;

        public CardModel(NorthwindContext context)
        {
            _context = context;
        }

        //public List<Entities.Categories> _categories { get; set; }
        public PaginatedList<LifeIn2.Domain.Entities.Category> _categories { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public string IdSort { get; set; }
        public string NameSort { get; set; }

        public async Task OnGetAsync(string sortOrder, int? pageIndex)
        {
            if (SearchString != null)
            {
                pageIndex = 1;
            }

            var categories = (from c in _context.Categories
                              select c);

            IdSort = string.IsNullOrEmpty(sortOrder) ? "id_desc" : "";
            NameSort = sortOrder == "CategoryName" ? "name_desc" : "name_asc";

            switch (sortOrder)
            {
                case "id_desc":
                    categories = categories.OrderByDescending(c => c.CategoryId);
                    break;
                case "name_asc":
                    categories = categories.OrderBy(c => c.CategoryName);
                    break;
                case "name_desc":
                    categories = categories.OrderByDescending(c => c.CategoryName);
                    break;
                default:
                    categories = categories.OrderBy(c => c.CategoryId);
                    break;
            }

            if (!string.IsNullOrEmpty(SearchString))
            {
                categories = categories.Where(c => c.CategoryName.Contains(SearchString));
            }

            int pageSize = 3;
            _categories = await PaginatedList<LifeIn2.Domain.Entities.Category>.CreateAsync(_context.Categories, pageIndex ?? 1, pageSize);
        }

        public ActionResult OnGetDelete(int? id)
        {
            if (id != null)
            {
                var data = (from categories in _context.Categories
                            where categories.CategoryId == id
                            select categories).FirstOrDefault();

                _context.Remove(data);
                _context.SaveChanges();
            }

            return RedirectToPage("Card");
        }
    }
}