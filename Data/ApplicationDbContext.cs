using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VuNgocTuyen715.Models;

namespace VuNgocTuyen715.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<VuNgocTuyen715.Models.Student> Student { get; set; } = default!;
    }
}
