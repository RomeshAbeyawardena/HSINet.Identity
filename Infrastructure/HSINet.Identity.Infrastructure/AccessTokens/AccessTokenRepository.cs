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
            if(filter.UserId.HasValue)
            {
                b.And(b => b.UserId == filter.UserId);
            }

            if(filter.AccessTokenId.HasValue)
            {
                b.And(b => b.Id == filter.AccessTokenId);
            }

            if(filter.TenantId.HasValue)
            {
                b.And(b => b.TenantId == filter.TenantId);
            }
        });
    }

    public async Task<AccessToken?> GetAccessToken(Filter filter, CancellationToken cancellationToken)
    {
        return await Filter(filter).FirstOrDefaultAsync(cancellationToken);
    }

    public async Task<IEnumerable<AccessToken>> GetAccessTokens(Filter filter, CancellationToken cancellationToken)
    {
        return await Filter(filter).ToListAsync(cancellationToken);
    }
}
