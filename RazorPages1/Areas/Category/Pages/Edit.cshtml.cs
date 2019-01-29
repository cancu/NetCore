using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LifeIn2.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;

namespace LifeIn2.RazorUI.Areas.Category.Pages
{
    public class EditModel : PageModel
    {
        public NorthwindContext _context { get; set; }
        private readonly IMapper _mapper;

        public EditModel(NorthwindContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [BindProperty]
        public CategoryVM CategoryVM { get; set; }

        public ActionResult OnGet(int? id)
        {
            if (id != null)
            {
                var category = _context.Categories.Find(id);

                if (category == null)
                {
                    return NotFound();
                }

                CategoryVM = _mapper.Map<CategoryVM>(category);

                return Page();
            }

            return RedirectToPage("./Card");
        }

        public async Task<IActionResult> OnPostUpdate()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //_context.Attach().State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            var category = await _context.Categories.FindAsync(CategoryVM.CategoryId);

            _mapper.Map<CategoryVM, Domain.Entities.Category>(CategoryVM, category);

            //_context.Attach(category);

            if (await TryUpdateModelAsync<Domain.Entities.Category>(category, "category",
                x => x.CategoryId, x => x.CategoryName, x => x.Description))
            {
                await _context.SaveChangesAsync();
                return RedirectToPage("./Card");
            }

            return Page();
        }

    }
}