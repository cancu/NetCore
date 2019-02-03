using LifeIn2.Application.Repository;
using LifeIn2.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;
using System.IO;
using System.Threading.Tasks;

namespace LifeIn2.RazorUI.Areas.Category.Pages
{
    public class CreateModel : PageModel
    {
        private readonly IRepositoryWrapper _repositoryWrapper;

        public CreateModel(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        [BindProperty]
        public CategoryVM CategoryVM { get; set; }

        public async Task<ActionResult> OnPost()
        {
            var category = new Domain.Entities.Category
            {
                CategoryName = CategoryVM.CategoryName,
                Description = CategoryVM.Description,
            };

            if (!ModelState.IsValid)
            {
                return Page();
            }

            using (var memoryStream = new MemoryStream())
            {
                await CategoryVM.Picture.CopyToAsync(memoryStream);
                category.Picture = memoryStream.ToArray();
            }

            _repositoryWrapper.Category.Add(category);
            _repositoryWrapper.Category.Save();

            return RedirectToPage("Card");
        }
    }
}