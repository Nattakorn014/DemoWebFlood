using System.ComponentModel.DataAnnotations.Schema;

namespace DemoWebFlood.Models
{
    public class TypeFlood
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string Title { get; set; }
        public List<PostType> PostTypesFlood { get; set; }
    }
}
