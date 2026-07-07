namespace Emax.Service.DTOs.StudentGroup;

public class StudentGroupCreationDto
{
    public long GroupId { get; set; }
    public long StudentId { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
