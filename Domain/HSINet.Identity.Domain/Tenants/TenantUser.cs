using System;

namespace HSINet.Identity.Domain.Tenants
{
    public class TenantUser
    {
        public Guid Id { get; set; }
        public Guid TenantId { get; set; }
        public Guid UserId { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset? ValidFrom { get; set; }
        public DateTimeOffset? ValidTo { get; set; }
        public bool IsBoarded { get; set; }
    }
}