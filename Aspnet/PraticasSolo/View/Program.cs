using Microsoft.EntityFrameworkCore;
using View.Data;
using View.Data.services;

var builder = WebApplication.CreateBuilder(args);

//Add services to the container.
builder.Services.AddControllersWithViews();
//Necessário para contexto do banco de dados e conexão
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ProjetoModeloAppContext>(options => options.UseMySql(connectionString,ServerVersion.AutoDetect(connectionString)));

builder.Services.AddScoped<ICarroService, CarroService>();
builder.Services.AddScoped<IImagemService, ImagemService>();
var app = builder.Build();

app.UseStaticFiles(); //obrigatório pois estou usando arquivos estáticos no webroot

app.MapControllerRoute(
    name: "default",
    pattern : "{controller=Carro}/{action=index}/{id?}").WithStaticAssets();

app.Run();
