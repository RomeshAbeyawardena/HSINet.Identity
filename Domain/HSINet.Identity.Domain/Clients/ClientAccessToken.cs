using HSINet.Shared.EntityAttributes;

namespace HSINet.Identity.Domain.Clients;

public class ClientAccessToken : IIdentity, ICreated, IModified
{
    public Guid? Id { get; set; }
    public Guid ClientId { get; set; }
    public Guid AccessTokenId { get; set; }
    public DateTimeOffset Created { get; set; }
    public DateTimeOffset? Modified { get; set; }

    public virtual Client? Client { get; set; }
    public virtual AccessTokens.AccessToken? AccessToken { get; set; }
}
