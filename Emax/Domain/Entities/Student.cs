using Emax.Domain.Configuration;

namespace Emax.Domain.Entities;

public class Student : Auditable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Group { get; set; }
    public int PhoneNumber { get; set; }
    public string Email { get; set; }
    public int Score { get; set; }
    public IEnumerable<StudentGroup> StudentGroups { get; set; }
}
