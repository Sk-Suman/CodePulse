using CodePulseProject.Model.Domain;
using Microsoft.EntityFrameworkCore;

namespace CodePulseProject.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options) 
        {

        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Blogpost> Blogsposts { get; set; }
       
    }
}
