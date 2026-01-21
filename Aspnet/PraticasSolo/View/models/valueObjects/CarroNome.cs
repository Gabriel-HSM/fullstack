namespace models.valueObjects
{
    //Não importa quem é, e sim o valor
    //È imutável
    //Se tiver dois com o mesmo valor são iguais -> record
    //Impede alteração depois de criado -> readonly
    public readonly record struct CarroNome
    {
        public string Nome { get;}

        public CarroNome(string nome)
        {

            //Nulo ou espaço em branco
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentException("O nome do carro não pode ser vazio", nameof(nome));
            }

            //Menor que 3 caracteres
            if(nome.Length < 3)
            {
                throw new ArgumentException("O nome do carro não pode ser menor que 3 caracteres", nameof(nome));
            }

            //Maior que 25
            if(nome.Length > 25)
            {
                throw new ArgumentException("O nome do carro não pode exceder 25 caracteres", nameof(nome));
            }

            Nome = nome;
        }

        //Sobrescreve a forma de escrita do objeto, mostrando o que ele possui
        public override string ToString()
        {
            return Nome;
        }
        
    }
}