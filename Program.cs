// Setup
using abdulmoez;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
var app = builder.Build();
Karnx Kch = new Karnx();
app.MapGet("/", () =>
{
    return Kch.kname + " " + Kch.khealth + " " + Kch.kstatus;
});
app.Run();
