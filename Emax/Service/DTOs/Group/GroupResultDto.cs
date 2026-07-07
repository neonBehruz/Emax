using Emax.Domain.Entities;
using Emax.Service.DTOs.Student;

namespace Emax.Service.DTOs.Group;

public class GroupResultDto
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Room { get; set; }
    public long? TeacherId { get; set; }    
    public IEnumerable<StudentResultDto> StudentGroups { get; set; }
}
