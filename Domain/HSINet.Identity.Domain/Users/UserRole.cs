using System;

namespace HSINet.Identity.Domain.Users
{
    public class UserRole
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }
        public DateTimeOffset ValidFrom { get; set; }
        public DateTimeOffset ValidTo { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public bool IsEnabled { get; set; }

        public virtual User? User { get; set; }
        public virtual Roles.Role? Role { get; set; }
    }
}