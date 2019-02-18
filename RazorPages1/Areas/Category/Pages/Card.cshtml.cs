using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages1.Common;
using CancuNetCore.Persistence;
using CancuNetCore.Domain;
using CancuNetCore.Application.Interfaces;

namespace CancuNetCore.RazorUI.Areas.Category.Pages
{
    public class CardModel : PageModel
    {
        private readonly IRepositoryWrapper _repositoryWrapper;

        public CardModel(IRepositoryWrapper repositoryWrapper)
        {
            this._repositoryWrapper = repositoryWrapper;
        }

        //public List<Entities.Categories> _categories { get; set; }
        [BindProperty]
        public PaginatedList<CancuNetCore.Domain.Entities.Category> _categories { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public string IdSort { get; set; }
        public string NameSort { get; set; }

        public void OnGet(string sortOrder, int? pageIndex)
        {
            if (SearchString != null)
            {
                pageIndex = 1;
            }

            //var categories = (from c in _context.Categories
            //                  select c);

            var categories = _repositoryWrapper.Category.GetAll();

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
            _categories = PaginatedList<Domain.Entities.Category>.Create(categories, pageIndex ?? 1, pageSize);
        }

        public ActionResult OnGetDelete(int? id)
        {
            if (id != null)
            {
                //var data = (from categories in _context.Categories
                //            where categories.CategoryId == id
                //            select categories).FirstOrDefault();

                var data = _repositoryWrapper.Category.GetById(id.Value);

                _repositoryWrapper.Category.Delete(data);
                _repositoryWrapper.Category.Save();
            }

            return RedirectToPage("Card");
        }
    }
}