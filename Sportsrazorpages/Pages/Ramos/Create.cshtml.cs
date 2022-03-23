#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sportsrazorpages.Data;

namespace Sportsrazorpages.Pages.Ramos
{
    public class CreateModel : PageModel
    {
        private readonly Sportsrazorpages.Data.SportsrazorpagesContext _context;

        public CreateModel(Sportsrazorpages.Data.SportsrazorpagesContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Sports Sports { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Sports.Add(Sports);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
