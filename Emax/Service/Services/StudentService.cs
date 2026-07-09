using AutoMapper;
using Emax.Data.IRepositories;
using Emax.Data.Repositories;
using Emax.Domain.Entities;
using Emax.Service.DTOs.Student;
using Emax.Service.DTOs.Teacher;
using Emax.Service.ExceptionHendler;
using Emax.Service.Interface;
using Emax.Service.MappingHelper;
using Microsoft.EntityFrameworkCore;

namespace Emax.Service.Services;

public class StudentService : IStudentService
{
    private IRepository<Student> studentRepository;
    private readonly IMapper _mapper;
    public StudentService()
    {
        this.studentRepository = new Repository<Student>();
        var config = new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile>());
        _mapper = config.CreateMapper();
    }
    public async Task<StudentResultDto> CreateAsync(StudentCreationDto dto)
    {
        var student = await this.studentRepository.RetrieveAll().FirstOrDefaultAsync(s => s.Email == dto.Email);
        if (student is not null)
        {
            throw new CustomException(409, "Student with this email already exists.");
        }
        var newStudent = _mapper.Map<Student>(dto);
        var result = await this.studentRepository.InsertAsync(newStudent);
        return _mapper.Map<StudentResultDto>(result);
    }

    public Task<bool> DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<StudentResultDto>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<StudentResultDto> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<StudentResultDto> UpdateAsync(StudentUpdateDto dto)
    {
        throw new NotImplementedException();
    }
}
