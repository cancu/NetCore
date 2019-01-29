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
        public NorthwindContext _Context { get; set; }
        public CreateModel(NorthwindContext context)
        {
            _Context = context;
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

            _Context.Add(category);
            await _Context.SaveChangesAsync();

            return RedirectToPage("Card");
        }
    }
}