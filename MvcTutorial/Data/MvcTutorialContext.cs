using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MvcTutorial.Models
{
    public class MvcTutorialContext : DbContext
    {
        public MvcTutorialContext (DbContextOptions<MvcTutorialContext> options)
            : base(options)
        {
        }

        public DbSet<MvcTutorial.Models.Movie> Movie { get; set; }
    }
}
