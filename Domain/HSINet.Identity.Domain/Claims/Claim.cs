using HSINet.Shared.EntityAttributes;

namespace HSINet.Identity.Domain.Claims;

public class Claim : IIdentity, ICreated, IModified
{
    public Guid? Id { get; set; }
    public string? Type { get; set; }
    public string? Subject { get; set; }
    public string? Value { get; set; }
    public DateTimeOffset Created { get; set; }
    public DateTimeOffset? Modified { get; set; }
}