
namespace LifeIn2.Application.Interfaces
{
    public interface IRepositoryWrapper
    {
        IUserRepository User { get; }
        ICategoryRepository Category { get; }
    }
}
