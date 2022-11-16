using DemoWebFlood.Data;
using DemoWebFlood.Interface;
using DemoWebFlood.Models;

namespace DemoWebFlood.Repositories
{
    public class TypeRepo : ITypeFlood
    {
        private readonly ManyToManyContext _context;
        public TypeRepo(ManyToManyContext context)
        {
            _context = context;
        }

        public void Delete(TypeFlood type)
        {
            _context.TypeFloods.Remove(type);
        }

        public List<TypeFlood> GetAll()
        {
            return _context.TypeFloods.ToList();
        }

        public TypeFlood GetById(string Id)
        {
            return _context.TypeFloods.FirstOrDefault(x => x.Id == Id);
        }

        public void Insert(TypeFlood type)
        {
            _context.TypeFloods.Add(type);
        }

        public void Update(TypeFlood type)
        {
            _context.TypeFloods.Update(type);
        }
    }
}
