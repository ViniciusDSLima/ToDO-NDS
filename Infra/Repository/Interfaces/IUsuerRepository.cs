using Domain.Entities;

namespace Infra.Repository.Interfaces;

public interface IUsuerRepository : IRepository<User>
{
    Task<User> FindByEmail(string email);
    void Add(User user);
    Task<bool> IsEmailInUse(string email);
}