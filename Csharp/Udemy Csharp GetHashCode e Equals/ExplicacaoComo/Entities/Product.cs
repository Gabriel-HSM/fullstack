namespace ExplicacaoComo.Entities
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() + Price.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            // Verifica se obj é do tipo Product
            // Se não for, retorna false (não são iguais)
            if (!(obj is Product))
            return false;


            //DOWNCAST - converte 'obj' (tipo object) para 'other' (tipo Product)
            // Aqui sabemos que é seguro porque já verificamos acima
            // 'other' agora tem acesso às propriedades Name e Price
            Product other = (Product)obj;

            //Compara as propriedades
            // this.Name com other.Name E this.Price com other.Price
            // Retorna true apenas se AMBAS forem iguais
            return Name.Equals(other.Name) && Price.Equals(other.Price);
        }
    }
}