namespace Infra.Repository.Interfaces;

public interface IUnitOfWork
{
    IUsuerRepository UsuerRepository { get; }
    IAssignmentRepository AssignmentRepository { get; }
    IAssignemntListRepository AssignemntListRepository { get; }

    void Commit(); 
}