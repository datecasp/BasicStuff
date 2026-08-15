using BasicStuff.Models.Dtos;
using BasicStuff.Models.Models;

namespace BasicStuff.Infra.Mappers;
public class EntitiesMappers<T> where T : class
{
    /// <summary>
    /// Given a DTO instance of type T (for example UsuarioDto) returns the corresponding entity instance (for example Usuario)
    /// by delegating to the specific mapper (e.g. UsuarioMapper).
    /// Throws InvalidOperationException when no mapper is available for the DTO type.
    /// </summary>
    public static object? DtoToEntity(T dto)
    {
        if (dto == null) return null;

        var dtoType = typeof(T);

        // Add mappings here as new DTO/entity pairs are introduced
        if (dto is UsuarioDto usuarioDto)
        {
            return UsuarioMapper.Dto_a_Entity(usuarioDto);
        }

        throw new InvalidOperationException($"No mapper registered for DTO type '{dtoType.FullName}'.");
    }

    /// <summary>
    /// Given an entity instance returns the mapped DTO of type T (for example if T is UsuarioDto and entity is Usuario).
    /// Throws InvalidOperationException when no mapper is available for the entity type.
    /// </summary>
    public static T? EntityToDto(object? entity)
    {
        if (entity == null) return null;

        // Map entities to DTOs depending on runtime type
        if (entity is Usuario usuario)
        {
            return UsuarioMapper.Entity_a_Dto(usuario) as T;
        }

        throw new InvalidOperationException($"No mapper registered for entity type '{entity.GetType().FullName}'.");
    }
}
