using AutoMapper;
using Emax.Data.IRepositories;
using Emax.Data.Repositories;
using Emax.Domain.Entities;
using Emax.Service.DTOs.StudentGroup;
using Emax.Service.ExceptionHendler;
using Emax.Service.Interface;
using Emax.Service.MappingHelper;
using Microsoft.EntityFrameworkCore;

namespace Emax.Service.Services;

public class StudentGroupService : IStudentGroupService
{
    private IRepository<StudentGroup> studentGroupRepository;
    private readonly IMapper _mapper;
    public StudentGroupService()
    {
        this.studentGroupRepository = new Repository<StudentGroup>();
        var config = new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile>());
        _mapper = config.CreateMapper();
    }
    public async Task<StudentGroupResultDto> CreateAsync(StudentGroupCreationDto dto)
    {
        var studentGroup = await this.studentGroupRepository
      .RetrieveAll().FirstOrDefaultAsync(s => s.StudentId == dto.StudentId && s.GroupId == dto.GroupId);

        if (studentGroup is not null)
        {
            throw new CustomException(409,
                "Student group with this name already exists.");
        }

        var newStudentGroup = _mapper.Map<StudentGroup>(dto);

        var result = await this.studentGroupRepository
            .InsertAsync(newStudentGroup);

        return _mapper.Map<StudentGroupResultDto>(result);
    }

    public Task<bool> DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<StudentGroupResultDto>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<StudentGroupResultDto> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<StudentGroupResultDto> UpdateAsync(StudentGroupUpdateDto dto)
    {
        throw new NotImplementedException();
    }
}
