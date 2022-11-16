using DemoWebFlood.Models;

namespace DemoWebFlood.Interface
{
    public interface ITypeFlood
    {
        List<TypeFlood> GetAll();
        TypeFlood GetById(string Id);
        void Insert(TypeFlood type);
        void Update(TypeFlood type);
        void Delete(TypeFlood type);
    }
}
