using System;
using System.Collections;
using System.Collections.Generic;
using BlogSystem.Models;

namespace BlogSystem.Model
{
    public class Post
    {
        public Post()
        {
            this.Comments = new HashSet<Comment>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Content { get; set; }

        public DateTime DateCreated { get; set; }

        public virtual ApplicationUser User { get; set; }

        public virtual HashSet<Comment> Comments { get; set; }
    }
}