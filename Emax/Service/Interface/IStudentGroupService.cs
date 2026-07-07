using Emax.Service.DTOs.Student;
using Emax.Service.DTOs.StudentGroup;

namespace Emax.Service.Interface;

public interface IStudentGroupService
{
    Task<StudentGroupResultDto> CreateAsync(StudentGroupCreationDto dto);
    Task<StudentGroupResultDto> UpdateAsync(StudentGroupUpdateDto dto);
    Task<bool> DeleteAsync(long id);
    Task<StudentGroupResultDto> GetByIdAsync(long id);
    Task<IEnumerable<StudentGroupResultDto>> GetAllAsync();
}
