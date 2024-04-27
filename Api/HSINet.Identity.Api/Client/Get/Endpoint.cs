using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace HSINet.Identity.Api.Client.Get;

public static class Endpoint
{
    /// <summary>
    /// Generates a client token using the client ID and client secret
    /// </summary>
    /// <param name="clientSecret"></param>
    /// <param name="clientId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<IActionResult> GetClientToken (
        string clientSecret, Guid clientId,
        CancellationToken cancellationToken)
    {
        return new OkObjectResult("hello");
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="clientToken"></param>
    /// <returns></returns>
    public static async Task<IStatusCodeHttpResult> VerifyToken(string clientToken)
    {
        return new StatusCodeHttpResult();
    }
}
