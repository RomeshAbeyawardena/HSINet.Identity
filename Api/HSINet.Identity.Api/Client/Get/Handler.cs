using HSINet.Identity.Domain.AccessTokens;
using HSINet.Identity.Domain.Clients;
using MediatR;

namespace HSINet.Identity.Api.Client.Get;

public class Handler(IClientRepository clientRepository,
    TimeProvider timeProvider) : IRequestHandler<Query, AccessToken?>
{
    public async Task<AccessToken?> Handle(Query request, CancellationToken cancellationToken)
    {
        var clienAccessTokens = await clientRepository
            .GetAccessTokens(Query.To(request), cancellationToken);
        var utcNow = timeProvider.GetUtcNow();
        var cAt = clienAccessTokens.FirstOrDefault(f => f.AccessToken != null 
            && f.AccessToken.IsEnabled 
            && f.AccessToken.ValidFrom < utcNow 
            && f.AccessToken.ValidTo >= utcNow);
        return cAt?.AccessToken;
        
    }
}
