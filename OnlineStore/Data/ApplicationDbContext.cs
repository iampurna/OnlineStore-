 using Microsoft.EntityFrameworkCore;
using OnlineStore.Models;

namespace OnlineStore.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options)
            :base(options) 
        {

        }
        public DbSet<Category>Categories  { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category{Id=1,Name="Hero",DisplayOrder=23},
                new Category{Id=2,Name="Purna", DisplayOrder=27}
             );
        }
    }
}
