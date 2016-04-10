using Curlyzon.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curlyzon.Repository
{
    public class CurlyzonDbContext : DbContext
    {
        public CurlyzonDbContext()
            : base("CurlyzonDbContext")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
              .ToTable("Users")
              .HasKey(e => e.UserId);
        }
    }
}
