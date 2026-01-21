using Microsoft.EntityFrameworkCore;
using View.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
//Necessário para contexto do banco de dados e conexão
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ProjetoModeloAppContext>(options => options.UseMySql(connectionString,ServerVersion.AutoDetect(connectionString)));
var app = builder.Build();

app.UseStaticFiles(); //obrigatório pois estou usando arquivos estáticos no webroot

app.MapControllerRoute(
    name: "default",
    pattern : "{controller=Carro}/{action=index}/{id?}").WithStaticAssets();

app.Run();
