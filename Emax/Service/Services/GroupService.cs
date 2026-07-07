using Emax.Service.DTOs.Group;
using Emax.Service.Interface;

namespace Emax.Service.Services;

public class GroupService : IGroupService
{
    public Task<GroupResultDto> CreateAsync(GroupCreationDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<GroupResultDto>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<GroupResultDto> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<GroupResultDto> UpdateAsync(GroupUpdateDto dto)
    {
        throw new NotImplementedException();
    }
}
