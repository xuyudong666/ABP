using WebApplication1;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddApplication<AppModule>();
var app = builder.Build();
app.InitializeApplicationAsync();

app.Run();
