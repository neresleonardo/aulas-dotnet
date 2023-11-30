var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World 5!");
app.MapPost("/user", () => new { Name = "Leonardo", Age = 25 });
app.MapGet("/AddHeader", (HttpResponse response) => response.Headers.Add("Teste", "Leonardo"));

app.MapGet("/AddHeader1", (HttpResponse response) => {
    response.Headers.Add("Teste", "Leonardo");
    return "Leonardo";
});

app.Run();
