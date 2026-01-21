namespace View.models.valueObjects
{
    public readonly record struct CarroPreco
    {
        public double Preco { get;}

        public CarroPreco(double preco)
        {
            //Preço vazio
            if (double.IsNaN(preco))
            {
                throw new ArgumentOutOfRangeException("O valor não pode ser vazio", nameof(preco));
            }

            //Preço menor que 0
            if (preco < 0)
            {
                throw new ArgumentOutOfRangeException("O valor não pode ser menor que 0", nameof(preco));
            }

            Preco = preco;
        }
        
    }
}