using Emax.Service.DTOs.Group;

namespace Emax.Service.DTOs.Teacher;

public class TeacherResultDto
{
    public long Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public IEnumerable<GroupResultDto> Groups { get; set; }
}
