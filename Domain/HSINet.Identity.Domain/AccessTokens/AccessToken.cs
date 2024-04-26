namespace HSINet.Identity.Domain.AccessTokens
{
    public class AccessToken
    {
        public Guid Id { get; set; }
        public Guid TenantId { get;set; }
        public string? Value { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public DateTimeOffset ValidFrom { get; set; }
        public DateTimeOffset ValidTo { get; set; }
        public bool IsEnabled { get; set; }
        public Guid UserId { get; set; }
        public Users.User? User { get; set; }
        public Tenants.Tenant? Tenant { get; set; }
    }
}