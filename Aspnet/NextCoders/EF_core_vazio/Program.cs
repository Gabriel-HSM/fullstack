using EF_core_vazio;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DbPrimeiraTentativa>(c => c.UseSqlServer("Host=;Port=;Database=;Username=;Password=;"));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
