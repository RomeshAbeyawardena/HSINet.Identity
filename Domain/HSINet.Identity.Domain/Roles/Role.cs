using System;

namespace HSINet.Identity.Domain.Roles
{
    public class Role
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsSuperUser { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset? Modified { get; set; }
    }
}