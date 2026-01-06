namespace EmocionarioDomain;

public class Usuario
{
    public Guid Id { get; private set; }
    public string PrimeiroNome { get; private set; }
    public string Sobrenome { get; private set; }
    public string Email { get; private set; }
    public DateOnly? DataNascimento { get; private set; }
    public DateTime DataCriacao {get; private set;}
    public DateTime? DataAtualizacao {get; private set;}


    private Usuario(){}

    public Usuario Criar(string nome, string sobrenome, string email)
    {
        new Usuario
        {
            Id = Guid.NewGuid(),
            PrimeiroNome = nome,
            Sobrenome = sobrenome,
            Email = email,
            DataCriacao = DateTime.UtcNow,
        };
    }

    public Usuario Atualizar(string nome, string sobrenome, string email)
    {
        new Usuario
        {
            Id = Guid.NewGuid(),
            PrimeiroNome = nome,
            Sobrenome = sobrenome,
            Email = email,
            DataAtualizacao = DateTime.UtcNow,
        };
    }

}
