namespace Emax.Service.DTOs.Student;

public class StudentCreationDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Group { get; set; }
    public int PhoneNumber { get; set; }
    public string Email { get; set; }
    public int Score { get; set; }
    public DateTime Created { get; set; } = DateTime.UtcNow;
}
