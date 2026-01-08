namespace EmocionarioApplication.Usuarios.DTOs
{
//RESPOSTA DO QUE PRECISA PRA TER UM USUARIO 

//OU SEJA O QUE VAI SER RETORNADO PARA QUEM CONSUMIR A API
    public sealed record UsuarioDto
    {
        public  required Guid Id { get; init; }
        public  required string Nome { get; init; }
        public  required string Sobrenome { get; init; }
        public  required string Email { get; init; }
        public DateOnly? DataNascimento { get; init; }
        public DateTime DataCriacao { get; init; }
        public DateTime? DataAtualizacao { get; init; }
        
    }
}