using System;

namespace HSINet.Identity.Domain.Tenants
{
    public class Tenant
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? LogoUrl { get; set; }
        public string? BrandedCssUrl { get; set; }
        public string? Heading { get; set; }
        public string? SubHeading { get; set; }
        public string? Footer { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public bool IsEnabled { get; set; }
    }
}