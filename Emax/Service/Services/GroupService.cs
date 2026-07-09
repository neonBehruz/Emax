using AutoMapper;
using Emax.Data.IRepositories;
using Emax.Domain.Entities;
using Emax.Service.DTOs.Group;
using Emax.Service.DTOs.Student;
using Emax.Service.ExceptionHendler;
using Emax.Service.Interface;
using Microsoft.EntityFrameworkCore;

namespace Emax.Service.Services;

public class GroupService : IGroupService
{
    private IRepository<Group> groupRepository;
    private readonly IMapper _mapper;
    public async Task<GroupResultDto> CreateAsync(GroupCreationDto dto)
    {
        var group = await this.groupRepository.RetrieveAll().FirstOrDefaultAsync(g => g.Name == dto.Name);
        if (group is not null)
        {
            throw new CustomException(409, "Group with this name already exists.");
        }
        var newGroup = _mapper.Map<Group>(dto);
        var result = await this.groupRepository.InsertAsync(newGroup);
        return _mapper.Map<GroupResultDto>(result);
    }

    public Task<bool> DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<GroupResultDto>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<GroupResultDto> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<GroupResultDto> UpdateAsync(GroupUpdateDto dto)
    {
        throw new NotImplementedException();
    }
}
