using Emax.Domain.Entities;
using Emax.Service.DTOs.Group;
using Emax.Service.DTOs.Student;

namespace Emax.Service.Interface;


public interface IGroupService
{
    Task<GroupResultDto> CreateAsync(GroupCreationDto dto);
    Task<GroupResultDto> UpdateAsync(GroupUpdateDto dto);
    Task<bool> DeleteAsync(Guid id);
    Task<GroupResultDto> GetByIdAsync(Guid id);
    Task<IEnumerable<GroupResultDto>> GetAllAsync();
}
