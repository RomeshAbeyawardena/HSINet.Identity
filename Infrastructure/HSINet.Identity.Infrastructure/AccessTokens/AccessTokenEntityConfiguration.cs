using Microsoft.EntityFrameworkCore;
using HSINet.Identity.Domain.AccessTokens;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HSINet.Identity.Infrastructure.AccessTokens;

public class AccessTokenEntityConfiguration : IEntityTypeConfiguration<AccessToken>
{
    public void Configure(EntityTypeBuilder<AccessToken> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Id).HasField($"{nameof(AccessToken)}Id");
    }
}
