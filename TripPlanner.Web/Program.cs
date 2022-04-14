var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "kopnięcie łosia - Gniądz");

app.Run();