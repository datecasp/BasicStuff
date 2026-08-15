using BasicStuff.Domain.Interfaces;
using BasicStuff.Models.Dtos;
using BasicStuff.Models.Models;
using Microsoft.Extensions.Logging;

namespace BasicStuff.Domain.Services;
public class UsuarioService : IUsuarioService
{
    private readonly IGenericRepository<Usuario> _usuarioRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly ILogger<UsuarioService> _logger;

    public UsuarioService(IGenericRepository<Usuario> usuarioRepository, IUnitOfWork unitOfWork, ILogger<UsuarioService> logger)
    {
        _usuarioRepository = usuarioRepository;
        _unitOfWork = unitOfWork;
        _logger = logger;
    }

    public async Task<IEnumerable<UsuarioDto>> GetAll()
    {
        IEnumerable<UsuarioDto> usuariosDtos = new List<UsuarioDto>();
        try
        {
             usuariosDtos = await _usuarioRepository.GetAll<UsuarioDto>();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while retrieving all users.");
            throw;
        }
        return usuariosDtos;
    }
}

