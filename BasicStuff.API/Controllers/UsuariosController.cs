using BasicStuff.Domain.Interfaces;
using BasicStuff.Models.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace BasicStuff.API.Controllers;
[ApiController]
[Route("[controller]")]
public class UsuariosController : ControllerBase
{
    private readonly ILogger<UsuariosController> _logger;
private readonly IUsuarioService _usuarioService;

    public UsuariosController(ILogger<UsuariosController> logger, IUsuarioService usuarioService)
    {
        _logger = logger;
        _usuarioService = usuarioService;
    }

    [HttpGet(Name = "GetUsuarios")]
    public async Task<IEnumerable<UsuarioDto>> GetAll()
    {
        return (await _usuarioService.GetAll()).ToList();
    }
}

