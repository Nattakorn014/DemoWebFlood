namespace DemoWebFlood.Interface
{
    public interface IUnitOfWork
    {
        IPost Post { get; }
        ITypeFlood typeFlood { get; }

        void Save();

    }
}
