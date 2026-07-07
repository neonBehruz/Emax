using Emax.Data.IRepositories;
using Emax.Data.Repositories;
using Emax.Domain.Entities;
using Emax.Service.DTOs.Teacher;
using Emax.Service.Interface;

namespace Emax.Service.Services;

public class TeacherService : ITeacherService
{
    private IRepository<Teacher> teacherRepository;
    private long _id;
    public TeacherService()
    {
        this.teacherRepository = new Repository<Teacher>();

        if(teacherRepository.SelectAll() == null)
            this._id = 1;
        else
            _id =++teacherRepository.SelectAll().ToList().LastOrDefault().Id;
    }
    public Task<TeacherResultDto> CreateAsync(TeacherCreationDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<TeacherResultDto>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<TeacherResultDto> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<TeacherResultDto> UpdateAsync(TeacherUpdateDto dto)
    {
        throw new NotImplementedException();
    }
}
