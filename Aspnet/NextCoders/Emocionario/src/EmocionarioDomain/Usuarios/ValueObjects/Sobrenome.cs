
namespace EmocionarioDomain.Usuarios.ValueObjects
{
    public readonly struct Sobrenome
    {
        public string Valor { get;}

        public Sobrenome(string valor)
        {
            //regras regras e regras
            //nome não pode ser nu
            if (string.IsNullOrWhiteSpace(valor))
            {
                throw new ArgumentException("bererere");
            }
            
            Valor = valor;
        }
    }
}