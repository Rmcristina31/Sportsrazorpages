#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sportsrazorpages.Data;

namespace Sportsrazorpages.Pages.Ramos
{
    public class DeleteModel : PageModel
    {
        private readonly Sportsrazorpages.Data.SportsrazorpagesContext _context;

        public DeleteModel(Sportsrazorpages.Data.SportsrazorpagesContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Sports Sports { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Sports = await _context.Sports.FirstOrDefaultAsync(m => m.ID == id);

            if (Sports == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Sports = await _context.Sports.FindAsync(id);

            if (Sports != null)
            {
                _context.Sports.Remove(Sports);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
