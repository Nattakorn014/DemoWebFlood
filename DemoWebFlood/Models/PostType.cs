namespace DemoWebFlood.Models
{
    public class PostType
    {
        public string PostId { get; set; }
        public string TypeFloodId { get; set; }
        public Post Post { get; set; }
        public TypeFlood TypeFlood { get; set; }
    }
}
