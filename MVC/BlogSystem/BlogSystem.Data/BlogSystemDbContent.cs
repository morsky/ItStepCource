using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using BlogSystem.Model;

namespace BlogSystem.Data
{
    public class BlogSystemDbContext : IdentityDbContext<User>
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