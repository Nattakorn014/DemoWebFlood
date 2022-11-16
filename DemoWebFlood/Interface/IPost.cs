using DemoWebFlood.Models;

namespace DemoWebFlood.Interface
{
    public interface IPost
    {
        List<Post> GetAll();
        Post GetById (string id);
        void insert(Post post);
        void update(Post post);
        void delete(Post post);
    }
}
