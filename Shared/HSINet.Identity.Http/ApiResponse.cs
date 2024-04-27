using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System.Text.Json.Serialization;

namespace HSINet.Identity.Http;

public static class ApiResponse
{
    public static ApiResponse<T> Result<T>(T data, int? code = null)
    {
        return new ApiResponse<T> { 
            Code = code, 
            Data = data 
        };
    }

    public static ApiResponse<object> Failure(string error, int? code = null)
    {
        return Failure<object>(error, code);
    }

    public static ApiResponse<T> Failure<T>(string error, int? code = null)
    {
        return new ApiResponse<T> { 
            Error = error, 
            Code = code 
        };
    }
}

public class ApiResponse<T> : IStatusCodeActionResult
{
    public T? Data { get; init; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Error { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? Code { get; init; }

    public DateTimeOffset RequestedTimeStampUtc { get; set; }
    public int? StatusCode => Code;

    public Task ExecuteResultAsync(ActionContext context)
    {
        var response = context.HttpContext.Response;
        response.StatusCode = StatusCode.GetValueOrDefault(200);
        return response.WriteAsJsonAsync(this);
    }
}
