using BasicStuff.Domain.Interfaces;
using BasicStuff.Infra.Context;
using BasicStuff.Models.Models;
using Microsoft.Extensions.Logging;

namespace BasicStuff.Infra.Repositories;
public class LibroRepository(ILogger<GenericRepository<Libro>> logger, AppDbContext context) : GenericRepository<Libro>(logger, context)
{
}