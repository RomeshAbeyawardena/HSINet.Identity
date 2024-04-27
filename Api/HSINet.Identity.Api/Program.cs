using HSINet.Identity.Api.Client;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();

var app = builder.Build();

app.AddClientEndpoints();
app.MapRazorPages();
app.Run();
