using BasicStuff.Domain.Interfaces;
using BasicStuff.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace BasicStuff.Infra.UoW;
public class UnitOfWork(AppDbContext context) : IUnitOfWork
{
    private readonly AppDbContext _context = context;

    public async Task<IEnumerable<T>> GetAll<T>() where T : class
    {
        return await _context.Set<T>().ToListAsync();
    }

    public Task<IEnumerable<TDto>> GetAllProjectedAsync<TDto>() where TDto : class
    {
        throw new NotImplementedException();
    }
}
