using System;
using System.Collections.Generic;

namespace BlogSystem.Models
{
    public class PostViewModel
    {
        public int Id { get; internal set; }

        public string Name { get; set; }

        public string Content { get; set; }

        public DateTime DateCreated { get; set; }

        public string UserName { get; set; }

        public ICollection<CommentViewModel> Comments { get; set; }
    }
}