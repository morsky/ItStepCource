using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using BlogSystem.Model;
using BlogSystem.Models;

namespace BlogSystem.Data
{
    public class BlogSystemDbContext : IdentityDbContext<ApplicationUser>
    {
        public BlogSystemDbContext()
            :base("BlogSystemConnection")
        {
            
        }

        public static BlogSystemDbContext Create()
        {
            return new BlogSystemDbContext();
        }

        public IDbSet<Post> Posts { get; set; }
    }
}