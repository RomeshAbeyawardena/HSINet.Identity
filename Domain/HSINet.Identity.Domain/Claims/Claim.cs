using System;

namespace HSINet.Identity.Domain.Claims
{
    public class Claim
    {
        public Guid Id { get; set; }
        public string? Type { get; set; }
        public string? Subject { get; set; }
        public string? Value { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset? Modified { get; set; }
    }
}