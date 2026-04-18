var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddSingleton<JournalService>();
var app = builder.Build();
app.UseRouting();
app.MapRazorPages();
app.UseStaticFiles();
app.Run();
