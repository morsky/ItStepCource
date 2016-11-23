using System;
using BlogSystem.Models;

namespace BlogSystem.Model
{
    public class Post
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Content { get; set; }

        public DateTime DateCreated { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
