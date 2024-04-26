using HSINet.Shared.EntityAttributes;

namespace HSINet.Identity.Domain.Users;

public class User : IIdentity, ICreated, IModified
{
    public Guid? Id { get; set; }
    public string? Username { get; set; }
    public string? EmailAddress { get; set; }
    public string? PasswordHash { get; set; }
    public string? DisplayName { get; set; }
    public  DateTimeOffset Created { get; set; }
    public bool IsEnabled { get; set; }
    public string? CrmReference { get; set; }
    public DateTimeOffset? Modified { get; set; }
}