namespace Fabula.Models
{
    public class ChildPost : IPost
    {
        public Post Parent { get; set; }
        public int ParentPostId { get; set; } // foreign key
        public int PostId { get; set; } // primary key
        public User Author { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
