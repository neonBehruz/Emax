namespace Emax.Domain.Configuration;
    public abstract class Auditable
    {
    public long Id { get; set; }
    public DateTime Created { get; set; }
    public DateTime Updated { get; set; } = DateTime.Now;
}
