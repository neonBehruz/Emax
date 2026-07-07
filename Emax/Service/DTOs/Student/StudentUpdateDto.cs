namespace Emax.Service.DTOs.Student;

public class StudentUpdateDto
{
    public long Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Group { get; set; }
    public int PhoneNumber { get; set; }
    public string Email { get; set; }
    public int Score { get; set; }
    public DateTime Updated { get; set; } = DateTime.UtcNow;
}
