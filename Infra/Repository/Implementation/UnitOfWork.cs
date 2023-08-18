using Domain.Entities;
using Infra.Context;
using Infra.Repository.Interfaces;

namespace Infra.Repository.Implementation;

public class UnitOfWork : IUnitOfWork
{
    public UserRepository _userRepository;
    public AssignmentRepository _assignmentRepository;
    public AssignmentListRepository _assignmentListRepository;
    public AppDbContext _context;


    public IUsuerRepository UsuerRepository
    {
        get
        {
            return _userRepository = _userRepository ?? new UserRepository(_context);
        }
    }

    public IAssignmentRepository AssignmentRepository
    {
        get
        {
            return _assignmentRepository = _assignmentRepository ?? new AssignmentRepository(_context);
        }
    }

    public IAssignemntListRepository AssignemntListRepository
    {
        get
        {
            return _assignmentListRepository = _assignmentListRepository ?? new AssignmentListRepository(_context); 
        }
    }

    public UnitOfWork(AppDbContext appDbContext)
    {
        _context = appDbContext;
    }
    
    public void Commit()
    {
        _context.SaveChanges();
    }

    public void Disponse()
    {
        _context.Dispose();
    }
    
}