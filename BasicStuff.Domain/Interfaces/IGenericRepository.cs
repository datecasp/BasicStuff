namespace BasicStuff.Domain.Interfaces;
public interface IGenericRepository<T> where T : class
{
    Task<T> Insert(T value);
    Task<T?> GetById(int id);
    Task<IEnumerable<TOut>> GetAll<TOut>() where TOut : class;
    void Update(T value);
    Task<bool> Delete(int id);
}

