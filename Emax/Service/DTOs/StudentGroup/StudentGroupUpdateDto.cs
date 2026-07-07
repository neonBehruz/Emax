namespace Emax.Service.DTOs.StudentGroup;

public class StudentGroupUpdateDto
{
    public long Id { get; set; }
    public long GroupId { get; set; }
    public long StudentId { get; set; }
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}
