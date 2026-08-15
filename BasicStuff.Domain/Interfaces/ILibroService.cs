using BasicStuff.Models.Dtos;

namespace BasicStuff.Domain.Interfaces
{
    public interface ILibroService
    {
        Task<IEnumerable<LibroDto>> GetAll();
    }
}
