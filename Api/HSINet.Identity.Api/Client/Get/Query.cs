using HSINet.Identity.Domain.AccessTokens;
using MediatR;

namespace HSINet.Identity.Api.Client.Get;

public class Query : IRequest<AccessToken?>
{
    public Guid? ClientId { get; init; }
    public string? ClientToken { get; init; }
    public string? Secret { get; init; }

    public static Domain.Clients.Filter To(Query query)
    {
        return new Domain.Clients.Filter
        {
            ClientToken = query.ClientToken,
            ClientId = query.ClientId,
            Secret = query.Secret
        };
    }
}
