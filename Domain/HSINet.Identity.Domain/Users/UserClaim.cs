using HSINet.Shared.EntityAttributes;

namespace HSINet.Identity.Domain.Users;

public class UserClaim : IIdentity, ICreated, IModified
{
    public Guid? Id { get; set; }
    public Guid UserId { get; set; }
    public Guid ClaimId { get; set; }
    public DateTimeOffset? ValidFrom { get; set; }
    public DateTimeOffset? ValidTo { get; set; }
    public DateTimeOffset Created { get; set; }
    public DateTimeOffset? Modified { get; set; }

    public virtual Claims.Claim? Claim { get; set; }
    public virtual User? User { get; set; } 
}