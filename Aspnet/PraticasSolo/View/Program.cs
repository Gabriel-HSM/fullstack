var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseStaticFiles(); //obrigatório pois estou usando arquivos estáticos no webroot

app.MapGet("/", async context =>
{
    context.Response.ContentType = "text/html";
    await context.Response.SendFileAsync("wwwroot/index.html");
});

app.Run();
