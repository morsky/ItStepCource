using System;
using BlogSystem.Model;

namespace BlogSystem.Models
{
    public class PostViewModel
    {
        public string Name { get; set; }

        public string Content { get; set; }

        public DateTime DateCreated { get; set; }

        public string UserName { get; set; }
    }
}