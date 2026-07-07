using Emax.Domain.Entities;

namespace Emax.Service.DTOs.Group;

public class GroupUpdateDto
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Room { get; set; }
    public long? TeacherId { get; set; }
    public DateTime? UpdatedAt { get; set; } = DateTime.UtcNow;
}
