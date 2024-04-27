using HSINet.Identity.Http;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HSINet.Identity.Api.Client.Get;

public static class V1
{
    /// <summary>
    /// Generates a client token using the client ID and client secret
    /// </summary>
    /// <param name="clientSecret"></param>
    /// <param name="clientId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<IResult> GetClientToken (
        IMediator mediator,
        [FromHeader]string clientSecret, [FromHeader] Guid clientId,
        CancellationToken cancellationToken)
    {
        var token = await mediator.Send(new Query {
            ClientId = clientId,
            Secret = clientSecret
        }, cancellationToken);

        //also check the token as it may not be initalised yet
        if (token == null || string.IsNullOrWhiteSpace(token.Value))
        {
            return ApiResponse.Failure("Invalid or expired token", 404);
        }

        return ApiResponse.Result(token);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="clientToken"></param>
    /// <returns></returns>
    public static async Task<IResult> VerifyToken(IMediator mediator,
        [FromHeader] string clientToken, CancellationToken cancellationToken)
    {
        var token = await mediator.Send(new Query
        {
            ClientToken = clientToken
        }, cancellationToken);

        //also check the token as it may not be initalised yet
        if(token == null || string.IsNullOrWhiteSpace(token.Value))
        {
            return ApiResponse.Failure("Invalid or expired token", 404);
        }

        return ApiResponse.Result(token);
    }
}
