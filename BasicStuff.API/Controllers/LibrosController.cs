using BasicStuff.Domain.Interfaces;
using BasicStuff.Models.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace BasicStuff.API.Controllers;
[ApiController]
[Route("[controller]")]
public class LibrosController : ControllerBase
{
    private readonly ILogger<LibrosController> _logger;
private readonly ILibroService _libroService;

    public LibrosController(ILogger<LibrosController> logger, ILibroService libroService)
    {
        _logger = logger;
        _libroService = libroService;
    }

    [HttpGet(Name = "GetLibros")]
    public async Task<IEnumerable<LibroDto>> GetAll()
    {
        return (await _libroService.GetAll()).ToList();
    }
}

