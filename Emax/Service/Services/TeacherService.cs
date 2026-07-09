using AutoMapper;
using Emax.Data.IRepositories;
using Emax.Data.Repositories;
using Emax.Domain.Entities;
using Emax.Service.DTOs.Teacher;
using Emax.Service.ExceptionHendler;
using Emax.Service.Interface;
using Emax.Service.MappingHelper;
using Microsoft.EntityFrameworkCore;

namespace Emax.Service.Services;

public class TeacherService : ITeacherService
{
    private IRepository<Teacher> teacherRepository;
    private readonly IMapper _mapper;
    public TeacherService()
    {
        this.teacherRepository= new Repository<Teacher>();
        var config = new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile>());
        _mapper = config.CreateMapper();
    }
    public async Task<TeacherResultDto> CreateAsync(TeacherCreationDto dto)
    {
        var teacher = await this.teacherRepository.
            RetrieveAll().
            FirstOrDefaultAsync(t => t.Email == dto.Email);
        if(teacher is not null)
        {
            throw new CustomException(409, "Teacher with this email already exists.");
        }
        var newTeacher = _mapper.Map<Teacher>(dto);
        var result = await this.teacherRepository.InsertAsync(newTeacher);
        return _mapper.Map<TeacherResultDto>(result);
    }

    public Task<bool> DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<TeacherResultDto>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<TeacherResultDto> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<TeacherResultDto> UpdateAsync(TeacherUpdateDto dto)
    {
        throw new NotImplementedException();
    }
}
