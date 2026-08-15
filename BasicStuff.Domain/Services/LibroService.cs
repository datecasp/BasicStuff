using BasicStuff.Domain.Interfaces;
using BasicStuff.Models.Dtos;
using BasicStuff.Models.Models;
using Microsoft.Extensions.Logging;

namespace BasicStuff.Domain.Services;
public class LibroService : ILibroService
{
    private readonly IGenericRepository<Libro> _libroRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly ILogger<LibroService> _logger;

    public LibroService(IGenericRepository<Libro> libroRepository, IUnitOfWork unitOfWork, ILogger<LibroService> logger)
    {
        _libroRepository = libroRepository;
        _unitOfWork = unitOfWork;
        _logger = logger;
    }

    public async Task<IEnumerable<LibroDto>> GetAll()
    {
        IEnumerable<LibroDto> LibrosDtos = new List<LibroDto>();
        try
        {
             LibrosDtos = await _libroRepository.GetAll<LibroDto>();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while retrieving all books.");
            throw;
        }
        return LibrosDtos;
    }
}

