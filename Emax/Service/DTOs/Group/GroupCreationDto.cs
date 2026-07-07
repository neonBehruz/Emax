
using Emax.Domain.Entities;

namespace Emax.Service.DTOs.Group;

public class GroupCreationDto
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Room { get; set; }
    public long? TeacherId { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
