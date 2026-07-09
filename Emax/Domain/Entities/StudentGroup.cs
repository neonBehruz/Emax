using Emax.Domain.Configuration;

namespace Emax.Domain.Entities;

public class StudentGroup : Auditable
{
    public Guid GroupId { get; set; }
    public Group Group { get; set; }
    public Guid StudentId { get; set; }
    public Student Student { get; set; }

}
