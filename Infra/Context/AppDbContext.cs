using Domain.Entities;
using Infra.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infra.Context;

public class AppDbContext : DbContext, IUnitOfWork
{

    public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
    { }
    
    public DbSet<User> Users { get; set;} 
    public DbSet<Assignment> Assignments { get; set;} 
    public DbSet<AssingnmentList> AssingnmentLists{ get; set;}
    
    public IUsuerRepository UsuerRepository { get; }
    public IAssignmentRepository AssignmentRepository { get; }
    public IAssignemntListRepository AssignemntListRepository { get; }
    public void Commit()
    {
        throw new NotImplementedException();
    }
}