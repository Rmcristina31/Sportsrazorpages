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
    public class IndexModel : PageModel
    {
        private readonly Sportsrazorpages.Data.SportsrazorpagesContext _context;

        public IndexModel(Sportsrazorpages.Data.SportsrazorpagesContext context)
        {
            _context = context;
        }

        public IList<Sports> Sports { get;set; }

        public async Task OnGetAsync()
        {
            Sports = await _context.Sports.ToListAsync();
        }
    }
}
