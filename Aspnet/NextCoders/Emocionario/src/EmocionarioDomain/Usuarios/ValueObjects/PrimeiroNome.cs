namespace EmocionarioDomain.Usuarios.ValueObjects
{
    public readonly record struct PrimeiroNome
    {
        public string Valor { get;}

        public PrimeiroNome(string valor)
        {
            //Nome não pode ser Nulo
            if (string.IsNullOrWhiteSpace(valor))
            {
                throw new ArgumentException("O Sobre nome não pode estar vazio.", nameof(valor));
            }

            //Não pode ser menor que 3 caracteres
            if (valor.Length < 3)
            {
                throw new ArgumentException("O primeiro nome deve ter no mínimo 3 caracteres.",nameof(valor));
            }

            //Não pode ter mais de 20 caracteres
            if (valor.Length > 30)
            {
                throw new ArgumentException("O primeiro nome deve ter no máximo 30 caracteres", nameof(valor));
            }

            Valor = valor;
        }

        //Não obrigatório
        public override string ToString() => Valor;
        public static implicit operator string(PrimeiroNome primeiroNome) => primeiroNome.Valor;
    }
}