using Emax.Domain.Entities;
using Emax.Service.DTOs.Student;
using Emax.Service.DTOs.StudentGroup;

namespace Emax.Service.DTOs.Group;

public class GroupResultDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Room { get; set; }
    public Guid? TeacherId { get; set; }    
    public IEnumerable<StudentGroupResultDto> StudentGroups { get; set; }
}
