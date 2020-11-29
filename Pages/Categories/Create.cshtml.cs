using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Lazar_Andreea_Lab8.Data;
using Lazar_Andreea_Lab8.Models;

namespace Lazar_Andreea_Lab8.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly Lazar_Andreea_Lab8.Data.Lazar_Andreea_Lab8Context _context;

        public CreateModel(Lazar_Andreea_Lab8.Data.Lazar_Andreea_Lab8Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Category Category { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Category.Add(Category);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
