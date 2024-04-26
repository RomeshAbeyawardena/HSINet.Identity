using HSINet.Shared;
using HSINet.Shared.Transactional;

namespace HSINet.Identity.Domain.AccessTokens;

public record Filter : PagedRequest, IDbQuery<AccessToken>
{
    public Guid? AccessTokenId { get; set; }
    public Guid? TenantId { get; set; }
    public Guid? UserId { get; set; }
    public bool AsNoTracking { get; }
}
