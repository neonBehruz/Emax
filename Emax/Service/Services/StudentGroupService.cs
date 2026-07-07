using Emax.Service.DTOs.StudentGroup;
using Emax.Service.Interface;

namespace Emax.Service.Services;

public class StudentGroupService : IStudentGroupService
{
    public Task<StudentGroupResultDto> CreateAsync(StudentGroupCreationDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<StudentGroupResultDto>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<StudentGroupResultDto> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<StudentGroupResultDto> UpdateAsync(StudentGroupUpdateDto dto)
    {
        throw new NotImplementedException();
    }
}
