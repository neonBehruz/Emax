namespace Emax.Domain.Configuration;
    public abstract class Auditable
    {
    public Guid Id { get; set; }= Guid.NewGuid();
    public DateTime Created { get; set; }
    public DateTime Updated { get; set; } = DateTime.Now;
}
