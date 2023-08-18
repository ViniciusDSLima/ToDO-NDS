using Domain.Entities;

namespace Infra.Repository.Interfaces;

public interface IAssignemntListRepository : IRepository<AssingnmentList>
{
    Task<AssingnmentList> GetById(int id, int userId);
    Task<AssingnmentList> GetByIdWithAssignments(int id, int userId);
    void Add(AssingnmentList assingnmentList);
    void Update(AssingnmentList assingnmentList);
    void Delete(AssingnmentList assingnmentList);
}