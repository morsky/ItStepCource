using System;

namespace BlogSystem.Model
{
    public class Comment
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public string Author { get; set; }

        public DateTime DateCreated { get; set; }

        public int PostId { get; set; }
    }
}