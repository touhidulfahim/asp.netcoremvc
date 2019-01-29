using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CoreMVCApp.Models
{
    public class CoreMVCAppContext : DbContext
    {
        public CoreMVCAppContext (DbContextOptions<CoreMVCAppContext> options)
            : base(options)
        {
        }

        public DbSet<CoreMVCApp.Models.Movie> Movie { get; set; }
    }
}
