using HSINet.Identity.Api.Client.Get;

namespace HSINet.Identity.Api.Client;

public static class Endpoints
{
    public static IEndpointRouteBuilder AddClientEndpoints(this IEndpointRouteBuilder builder)
    {
        builder.MapPost("/client", V1.GetClientToken);
        builder.MapGet("/client", V1.VerifyToken);
        return builder;
    }
}
