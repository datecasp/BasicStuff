using BasicStuff.Models.Dtos;
using BasicStuff.Models.Models;

namespace BasicStuff.Infra.Mappers;
public static class LibroMapper
{
    public static LibroDto Entity_a_Dto(Libro entity)
    {
        if (entity == null) return new LibroDto();
        return new LibroDto
        {
            Id = entity.Id,
            Title = entity.Title,
            Author = entity.Author
        };
    }

    public static Libro Dto_a_Entity(LibroDto dto)
    {
        if (dto == null) return new Libro();
        return new Libro
        {
            Id = dto.Id,
            Title = dto.Title,
            Author = dto.Author
        };
    }
}
