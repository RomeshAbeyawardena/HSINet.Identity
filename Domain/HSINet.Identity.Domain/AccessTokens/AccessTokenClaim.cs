using HSINet.Shared.EntityAttributes;

namespace HSINet.Identity.Domain.AccessTokens;

public class AccessTokenClaim : IIdentity, ICreated, IModified
{
    public Guid? Id { get; set; }
    public Guid AccessTokenId { get; set; }
    public Guid ClaimId {get; set; }
    public DateTimeOffset? ValidFrom { get; set; }
    public DateTimeOffset? ValidTo { get; set; }
    public AccessToken? AccessToken { get; set; }
    public Claims.Claim? Claim { get; set; }
    public DateTimeOffset Created { get; set; }
    public DateTimeOffset? Modified { get; set; }
}