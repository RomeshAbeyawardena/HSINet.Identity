using HSINet.Shared.EntityAttributes;

namespace HSINet.Identity.Domain.Clients;

public class Client : IIdentity, ICreated, IModified
{
    public Guid? Id { get; }
    public DateTimeOffset Created { get; set; }
    public DateTimeOffset? Modified { get; set; }
}
