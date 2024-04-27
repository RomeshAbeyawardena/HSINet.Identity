namespace HSINet.Identity.Domain.Clients;

public class Filter
{
    public Guid? ClientId { get; init; }
    public string? ClientToken { get; init; }
    public string? Secret { get; init; }
}
