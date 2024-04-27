using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System.Text.Json.Serialization;

namespace HSINet.Identity.Http;

public class ApiResponse<T> : IStatusCodeActionResult
{
    public required T Data { get; init; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Error { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? Code { get; init; }

    public DateTimeOffset RequestedTimeStampUtc { get; set; }
    public int? StatusCode { get; }

    public Task ExecuteResultAsync(ActionContext context)
    {
        var response = context.HttpContext.Response;
        response.StatusCode = StatusCode.GetValueOrDefault(200);
        return response.WriteAsJsonAsync(this);
    }
}
