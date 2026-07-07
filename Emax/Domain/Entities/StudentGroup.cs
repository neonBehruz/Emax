using Emax.Domain.Configuration;

namespace Emax.Domain.Entities;

public class StudentGroup : Auditable
{
    public long GroupId { get; set; }
    public Group Group { get; set; }
    public long StudentId { get; set; }
    public Student Student { get; set; }

}
