namespace EmocionarioDomain.Usuarios.ValueObjects
{
    public readonly struct PrimeiroNome
    {
        public string Valor { get;}

        public PrimeiroNome(string valor)
        {
            //regras regras e regras
            //nome não pode ser nu
            if (string.IsNullOrWhiteSpace(valor))
            {
                throw new ArgumentException("bererere");
            }
            Valor = valor;
        }

        //Não obrigatório
        public override string ToString()
        {
            return Valor;
            // ou => Valor
        }
    }
}