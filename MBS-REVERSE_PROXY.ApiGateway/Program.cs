using MBS_REVERSE_PROXY.ApiGateway.DependencyInjection.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddJwtAuthenticationApiGateway(builder.Configuration);
builder.Services.AddReverseProxyApiGateway(builder.Configuration);

var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();

app.MapReverseProxy();

app.Run();