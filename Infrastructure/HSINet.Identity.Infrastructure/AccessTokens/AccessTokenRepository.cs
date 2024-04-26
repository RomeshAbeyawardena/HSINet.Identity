using HSINet.Identity.Domain.AccessTokens;
using HSINet.Shared.Infrastructure;
using HSINet.Shared.Infrastructure.Interceptors.Providers;
using HSINet.Shared.TypeCache;
using Microsoft.EntityFrameworkCore;

namespace HSINet.Identity.Infrastructure.AccessTokens;

public class AccessTokenRepository(HSINetIdentityDbContext context,
    IRepositoryInterceptorFactoryProvider factory, ITypeCacheProvider typeCacheProvider)
    : RepositoryBase<AccessToken, HSINetIdentityDbContext>(context, factory, typeCacheProvider),
    IAccessTokenRepository
{
    private IQueryable<AccessToken> Filter(Filter filter)
    {
        return this.Query(filter, (c,b) =>
        {
            
        });
    }

    public async Task<AccessToken?> GetAccessToken(Filter filter, CancellationToken cancellationToken)
    {
        return await Filter(filter).FirstOrDefaultAsync(cancellationToken);
    }

    public Task<IEnumerable<AccessToken>> GetAccessTokens(Filter filter, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
