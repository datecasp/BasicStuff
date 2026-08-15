using BasicStuff.Models.Dtos;
using BasicStuff.Models.Models;

namespace BasicStuff.Helpers.Mappers;
public static class UsuarioMapper
{
    public static UsuarioDto Entity_a_Dto(Usuario entity)
    {
        if (entity == null) return new UsuarioDto();
        return new UsuarioDto
        {
            Id = entity.Id,
            Name = entity.Name,
            Email = entity.Email
        };
    }

    public static Usuario Dto_a_Entity(UsuarioDto dto)
    {
        if (dto == null) return new Usuario();
        return new Usuario
        {
            Id = dto.Id,
            Name = dto.Name,
            Email = dto.Email
        };
    }
}
