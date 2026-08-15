using BasicStuff.Models.Dtos;
using BasicStuff.Models.Models;

namespace BasicStuff.Infra.Mappers;
public static class UsuarioMapper
{
    public static UsuarioDto Entity_a_Dto(Usuario entity)
    {
        if (entity == null) return new UsuarioDto();
        return new UsuarioDto
        {
            Id = entity.Id,
            UserName = entity.UserName,
            IsActive = entity.IsActive
        };
    }

    public static Usuario Dto_a_Entity(UsuarioDto dto)
    {
        if (dto == null) return new Usuario();
        return new Usuario
        {
            Id = dto.Id,
            UserName = dto.UserName,
            IsActive = dto.IsActive
        };
    }
}
