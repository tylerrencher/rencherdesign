using RencherDesign.Endpoints;
using RencherDesign.Services;

var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseKestrel(options => options.AddServerHeader = false);
builder.Host.UseDefaultServiceProvider(static config =>
{
    config.ValidateOnBuild = true;
});

builder.Services.AddRazorPages();
builder.Services.AddSingleton<JournalService>();
builder.Services.AddSingleton<EstimatorService>();

var app = builder.Build();
app.UseRouting();
app.MapRazorPages();
ProjectEstimationEndpoints.Map(app);
app.UseStaticFiles();
app.Run();
