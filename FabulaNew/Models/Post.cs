﻿namespace Fabula.Models
{
    public class Post : IPost
    {
        public ICollection<ChildPost> Child { get; set; }
        public int PostId { get; set; }
        public User Author { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
