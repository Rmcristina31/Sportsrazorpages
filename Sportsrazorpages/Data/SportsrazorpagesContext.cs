#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sportsrazorpages.Pages.Ramos;

namespace Sportsrazorpages.Data
{
    public class SportsrazorpagesContext : DbContext
    {
        public SportsrazorpagesContext (DbContextOptions<SportsrazorpagesContext> options)
            : base(options)
        {
        }

        public DbSet<Sportsrazorpages.Pages.Ramos.Sports> Sports { get; set; }
    }
}
