using Emax.Domain.Configuration;

namespace Emax.Domain.Entities;
public class Group : Auditable
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Room { get; set; }
    public Teacher Teacher { get; set; }
    public Guid? TeacherId { get; set; }
    public IEnumerable<StudentGroup> StudentGroups { get; set; }
 
}
