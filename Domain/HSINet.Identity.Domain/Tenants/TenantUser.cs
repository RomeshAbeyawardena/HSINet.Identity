using HSINet.Shared.EntityAttributes;

namespace HSINet.Identity.Domain.Tenants;

public class TenantUser : IIdentity, ICreated, IModified
{
    public Guid? Id { get; set; }
    public Guid TenantId { get; set; }
    public Guid UserId { get; set; }
    public DateTimeOffset Created { get; set; }
    public DateTimeOffset? ValidFrom { get; set; }
    public DateTimeOffset? ValidTo { get; set; }
    public bool IsBoarded { get; set; }
    public DateTimeOffset? Modified { get; set; }
}