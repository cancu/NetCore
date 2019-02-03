
namespace LifeIn2.Application.Repository
{
    public interface IRepositoryWrapper
    {
        IUserRepository User { get; }
        ICategoryRepository Category { get; }
    }
}
