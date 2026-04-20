var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseKestrel(options => options.AddServerHeader = false);
builder.Services.AddRazorPages();
builder.Services.AddSingleton<JournalService>();
var app = builder.Build();
app.UseRouting();
app.MapRazorPages();
app.UseStaticFiles();
app.Run();
