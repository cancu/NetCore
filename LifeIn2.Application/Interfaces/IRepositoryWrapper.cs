
namespace CancuNetCore.Application.Interfaces
{
    public interface IRepositoryWrapper
    {
        IUserRepository User { get; }
        ICategoryRepository Category { get; }
    }
}
