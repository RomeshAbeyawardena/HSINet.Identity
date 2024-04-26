using HSINet.Shared.Transactional;

namespace HSINet.Identity.Domain.AccessTokens;

public interface IAccessTokenRepository : IRepository<AccessToken>
{
    Task<AccessToken?> GetAccessToken(Filter filter, CancellationToken cancellationToken);
    Task<IEnumerable<AccessToken>> GetAccessTokens(Filter filter, CancellationToken cancellationToken);
}
