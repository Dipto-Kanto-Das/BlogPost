using BlogNest.Presentation.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogNest.Presentation.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> a) : base(a)
        {

        }
        public DbSet<BlogPost> BlogPosts { get; set; }


    }
}
