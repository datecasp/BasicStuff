namespace BasicStuff.Domain.Interfaces;
public interface IUnitOfWork
{
    Task<IEnumerable<T>> GetAll<T>() where T : class;
    Task<IEnumerable<TDto>> GetAllProjectedAsync<TDto>() where TDto : class;
}
