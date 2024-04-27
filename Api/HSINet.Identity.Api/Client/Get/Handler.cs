using HSINet.Identity.Api.AccessTokens.Post;
using HSINet.Identity.Domain.AccessTokens;
using HSINet.Identity.Domain.Clients;
using MediatR;

namespace HSINet.Identity.Api.Client.Get;

public class Handler(IClientRepository clientRepository,
    IMediator mediator, TimeProvider timeProvider) 
    : IRequestHandler<Query, AccessToken?>
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

        if(cAt == null)
        {
            var accessToken = await mediator.Send(new Command {
                Entity = new AccessToken { 

                },
                CommitChanges = false,
            }, cancellationToken);

            var client = await clientRepository.FindAsync([request.ClientId!], cancellationToken);

            if(client != null)
            {
                
            }
        }

        return cAt?.AccessToken;
        
    }
}
