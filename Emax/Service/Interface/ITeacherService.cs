using Emax.Service.DTOs.Student;
using Emax.Service.DTOs.Teacher;

namespace Emax.Service.Interface;

public interface ITeacherService
{
    Task<TeacherResultDto> CreateAsync(TeacherCreationDto dto);
    Task<TeacherResultDto> UpdateAsync(TeacherUpdateDto dto);
    Task<bool> DeleteAsync(long id);
    Task<TeacherResultDto> GetByIdAsync(long id);
    Task<IEnumerable<TeacherResultDto>> GetAllAsync();
}
