using System;

namespace BlogSystem.Model
{
    public class Post
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Content { get; set; }

        public DateTime DateCreated { get; set; }

        public virtual User User { get; set; }
    }
}
