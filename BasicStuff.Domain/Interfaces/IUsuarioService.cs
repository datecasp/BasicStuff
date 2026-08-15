using BasicStuff.Models.Dtos;

namespace BasicStuff.Domain.Interfaces
{
    public interface IUsuarioService
    {
        Task<IEnumerable<UsuarioDto>> GetAll();
    }
}
