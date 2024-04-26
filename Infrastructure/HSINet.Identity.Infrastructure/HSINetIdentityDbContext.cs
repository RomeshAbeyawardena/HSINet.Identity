using HSINet.Shared.Transactional;
using Microsoft.EntityFrameworkCore;

namespace HSINet.Identity.Infrastructure;

public class HSINetIdentityDbContext : DbContext, IUnitOfWork
{

}
