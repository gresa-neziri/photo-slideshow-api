var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/optimize", (HttpRequest request) => {
    return "Hello Worldf!"; 
    });

app.Run();
