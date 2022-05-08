namespace Fabula.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public User Author { get; set; }
        public Post ParentPost { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
