using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CancuNetCore.Application.Interfaces;
using CancuNetCore.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;

namespace CancuNetCore.RazorUI.Areas.Category.Pages
{
    public class EditModel : PageModel
    {
        private readonly IRepositoryWrapper _repositoryWrapper;

        //public NorthwindContext _context { get; set; }
        private readonly IMapper _mapper;

        public EditModel(IRepositoryWrapper repositoryWrapper, IMapper mapper)
        {
            _repositoryWrapper = repositoryWrapper;
            _mapper = mapper;
        }

        [BindProperty]
        public CategoryVM CategoryVM { get; set; }

        public ActionResult OnGet(int? id)
        {
            if (id != null)
            {
                var category = _repositoryWrapper.Category.GetById(id.Value);

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

            var category = _repositoryWrapper.Category.GetById(CategoryVM.CategoryId);

            _mapper.Map<CategoryVM, Domain.Entities.Category>(CategoryVM, category);

            //_context.Attach(category);

            if (await TryUpdateModelAsync<Domain.Entities.Category>(category, "category",
                x => x.CategoryId, x => x.CategoryName, x => x.Description))
            {
                await _repositoryWrapper.Category.SaveAsync();
                return RedirectToPage("./Card");
            }

            return Page();
        }

    }
}