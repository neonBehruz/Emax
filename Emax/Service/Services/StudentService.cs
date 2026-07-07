using Emax.Service.DTOs.Student;
using Emax.Service.Interface;

namespace Emax.Service.Services;

public class StudentService : IStudentService
{
    public Task<StudentResultDto> CreateAsync(StudentCreationDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<StudentResultDto>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<StudentResultDto> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<StudentResultDto> UpdateAsync(StudentUpdateDto dto)
    {
        throw new NotImplementedException();
    }
}
