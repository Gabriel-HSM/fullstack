var builder = WebApplication.CreateBuilder(args);
// 0) Configurações 

//1) configura o construtor
builder.Services.AddControllers();

// 2) Construimos a aplicação
var app = builder.Build();

// 3) Metodos (get, post, put, delete) com sua rota. Exemplo: MapGet, MapPost, MapPut, MapDelete, Define as rotas e o que cada rota faz 
// Outro exemplo MapGet("/aluno")
// app.MapGet("/", () => "Hello World!");

app.MapControllers();


//4) inicializa a aplicação
app.Run();
