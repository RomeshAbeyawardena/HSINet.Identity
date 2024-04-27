using HSINet.Shared.Transactional;

namespace HSINet.Identity.Domain.Clients;

public interface IClientRepository : IRepository<Client>
{
    Task<IEnumerable<Client>> GetClients(Filter filter, CancellationToken cancellationToken);
    Task<IEnumerable<ClientAccessToken>> GetAccessTokens(Filter filter, CancellationToken cancellationToken);
}
