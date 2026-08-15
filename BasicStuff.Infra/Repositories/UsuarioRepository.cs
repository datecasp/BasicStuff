using BasicStuff.Domain.Interfaces;
using BasicStuff.Infra.Context;
using BasicStuff.Models.Models;
using Microsoft.Extensions.Logging;

namespace BasicStuff.Infra.Repositories;
public class UsuarioRepository(ILogger<GenericRepository<Usuario>> logger, AppDbContext context) : GenericRepository<Usuario>(logger, context)
{
}