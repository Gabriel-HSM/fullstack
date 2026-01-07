namespace EmocionarioDomain.Usuarios.ValueObjects
{
    public readonly record struct Sobrenome
    {
        public string Valor { get;}

        public Sobrenome(string valor)
        {
            //Nome não pode ser Nulo
            if (string.IsNullOrWhiteSpace(valor))
            {
                throw new ArgumentException("O Sobrenome não pode estar vazio.", nameof(valor));
            }

            //Não pode ser menor que 3 caracteres
            if (valor.Length < 3)
            {
                throw new ArgumentException("O Sobrenome deve ter no mínimo 3 caracteres.",nameof(valor));
            }

            //Não pode ter mais de 20 caracteres
            if (valor.Length > 30)
            {
                throw new ArgumentException("O Sobrenome deve ter no máximo 30 caracteres", nameof(valor));
            }
            
            Valor = valor;
        }
        public override string ToString() => Valor;
        public static implicit operator string(Sobrenome sobrenome) => sobrenome.Valor;
    }
}