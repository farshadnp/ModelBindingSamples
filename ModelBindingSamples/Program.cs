var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();



var app = builder.Build();
app.MapDefaultControllerRoute();
app.MapRazorPages();
app.UseHttpsRedirection();


//app.MapGet("/", () => "Hello World!");

app.Run();
