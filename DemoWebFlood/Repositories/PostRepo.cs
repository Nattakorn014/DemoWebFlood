using DemoWebFlood.Data;
using DemoWebFlood.Interface;
using DemoWebFlood.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoWebFlood.Repositories
{
    public class PostRepo : IPost
    {
        private readonly ManyToManyContext _context;
        public PostRepo(ManyToManyContext context)
        {
            _context = context;
        }

        public void delete(Post post)
        {
            _context.Posts.Remove(post);
        }

        public List<Post> GetAll()
        {
            return _context.Posts.ToList();
        }

        public Post GetById(string Id)
        {
            return _context.Posts.Include("PostType.TypeFlood").FirstOrDefault(x => x.Id==Id);
        }

        public void insert(Post post)
        {
            _context.Posts.Add(post);
        }

        public void update(Post post)
        {
            _context.Posts.Update(post);
        }
    }
}
