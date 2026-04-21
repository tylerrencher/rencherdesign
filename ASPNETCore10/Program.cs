using Services;

var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseKestrel(options => options.AddServerHeader = false);
builder.Host.UseDefaultServiceProvider(static config =>
{
    config.ValidateOnBuild = true;
});
builder.Services.AddRazorPages();
builder.Services.AddSingleton<JournalService>();
var app = builder.Build();
app.UseRouting();
app.MapRazorPages();
app.UseStaticFiles();
app.Run();
