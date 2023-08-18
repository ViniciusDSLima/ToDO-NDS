using Domain.Entities;

namespace Infra.Repository.Interfaces;

public interface IAssignmentRepository : IRepository<Assignment>
{
    Task<Assignment> GetById(int id, int userId);
    void Add(Assignment assignment);
    void Update(Assignment assignment);
    void Delete(Assignment assignment);
}