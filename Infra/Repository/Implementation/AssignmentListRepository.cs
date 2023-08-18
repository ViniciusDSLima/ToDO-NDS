using System.ComponentModel;
using Domain.Entities;
using Infra.Context;
using Infra.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Infra.Repository.Implementation;

public class AssignmentListRepository : Repository<AssingnmentList> , IAssignemntListRepository
{
    protected readonly AppDbContext _context;
    protected IUnitOfWork _unitOfWork => _context;

    public AssignmentListRepository(AppDbContext context) : base(context)
    {
        _context = context;
    }


    public async Task<AssingnmentList> GetById(int id, int userId)
    {
        return await _context.AssingnmentLists.FirstOrDefaultAsync(i => i.Id == id&& i.UserId == userId);
    }

    public async Task<AssingnmentList> GetByIdWithAssignments(int id, int userId)
    {
        return await _context.AssingnmentLists
            .Include(a => a.Assignments)
            .FirstOrDefaultAsync(a => a.Id == id && a.UserId == userId);
    }

    public void Add(AssingnmentList assingnmentList)
    {
        _context.AssingnmentLists.Add(assingnmentList);
    }

    public void Update(AssingnmentList assingnmentList)
    {
        _context.AssingnmentLists.Update(assingnmentList);
    }

    public void Delete(AssingnmentList assingnmentList)
    {
        _context.AssingnmentLists.Remove(assingnmentList);
    }

    public void Disponse()
    {
        _context.Dispose();
    }
    
}