using HSINet.Identity.Domain.AccessTokens;
using HSINet.Shared;
using HSINet.Shared.Transactional;
using MediatR;

namespace HSINet.Identity.Api.AccessTokens.Post
{
    public class Command : IRequest<AccessToken>, IDbCommand<AccessToken>
    {
        public required AccessToken Entity { get; init; }
        public UpsertOptions? Options { get; init; }
        public bool CommitChanges { get; init; }
    }
}
