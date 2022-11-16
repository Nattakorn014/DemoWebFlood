
using DemoWebFlood.Data;
using DemoWebFlood.Interface;

namespace DemoWebFlood.Repositories
{
    public class UnitOfWorkRepo : IUnitOfWork
    {
        private readonly ManyToManyContext _context;
        private IPost _postRepo;
        private ITypeFlood _typeRepo;
        public UnitOfWorkRepo(ManyToManyContext context)
        {
            _context = context;
        }
        public IPost Post
        {
            get
            {
                return _postRepo = _postRepo??new PostRepo(_context);
            }
        }

        public ITypeFlood typeFlood
        {
            get
            {
                return _typeRepo =_typeRepo?? new TypeRepo(_context);
            }
        }


        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
