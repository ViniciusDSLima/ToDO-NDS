using Domain.Entities;
using Infra.Context;
using Infra.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repository.Implementation;

public class UserRepository : Repository<User> , IUsuerRepository
{
    protected readonly AppDbContext _context;

    protected IUnitOfWork _unitOfWork => _context;
    public UserRepository(AppDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<User> FindByEmail(string email)
    {
        return await _context.Users.FirstOrDefaultAsync(e => e.Email == email);
    }

    public async Task<bool> IsEmailInUse(string email)
    {
        return await _context.Users.AnyAsync(e => e.Email == email);
    }

    public void Add(User user)
    {
        _context.Users.Add(user);
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}