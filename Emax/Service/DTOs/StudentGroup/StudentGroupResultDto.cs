using Emax.Service.DTOs.Group;
using Emax.Service.DTOs.Student;
using System.Text.RegularExpressions;

namespace Emax.Service.DTOs.StudentGroup;

public class StudentGroupResultDto
{
    public long Id { get; set; }
    public GroupResultDto Group { get; set; }
    public StudentResultDto Student { get; set; }
}
