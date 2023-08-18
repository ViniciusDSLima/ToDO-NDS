using Domain.Entities;
using Infra.Context;
using Infra.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repository.Implementation;

public class AssignmentRepository : Repository<Assignment> , IAssignmentRepository
{
   protected readonly AppDbContext _context;
   protected IUnitOfWork _unitOfWork => _context;

   public AssignmentRepository(AppDbContext context) : base(context)
   {
      _context = context;
   }

   public async Task<Assignment> GetById(int id, int userId)
   {
      return await _context.Assignments.FirstOrDefaultAsync(i => i.Id == id && i.UserId == userId);
   }

   public void Add(Assignment assignment)
   {
      _context.Assignments.Add(assignment);
   }

   public void Update(Assignment assignment)
   {
      _context.Assignments.Update(assignment);
   }

   public void Delete(Assignment assignment)
   {
      _context.Assignments.Remove(assignment);
   }

   public void Dispose()
   {
      _context.Dispose();
   }
}