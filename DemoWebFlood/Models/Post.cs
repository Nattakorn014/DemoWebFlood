namespace DemoWebFlood.Models
{
    public class Post
    {
        public string Id { get; set; }
        public string Place { get; set; }
        public string Description { get; set; }
        public List<PostType> PostsType { get; set; } = new List<PostType>();
    }
}
