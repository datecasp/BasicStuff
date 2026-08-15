using BasicStuff.Domain.Interfaces;
using BasicStuff.Infra.Context;
using BasicStuff.Infra.Mappers;
using Microsoft.Extensions.Logging;

namespace BasicStuff.Infra.Repositories;
public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    public ILogger<GenericRepository<T>> _logger;
    public AppDbContext _context;
    public GenericRepository(ILogger<GenericRepository<T>> logger, AppDbContext context) 
    { 
        _logger = logger;
        _context = context;
    }
    public async Task<T> Insert(T value) { return null; }
    public async Task<T?> GetById(int id) { return null; }
    public async Task<IEnumerable<TOut>> GetAll<TOut>() where TOut : class 
    {
        IEnumerable<TOut> valores = _context.Set<T>().ToList().Select(EntitiesMappers<TOut>.EntityToDto);
        return valores;
    }
    public async void Update(T value) { }
    public async Task<bool> Delete(int id) { return true; }
}

