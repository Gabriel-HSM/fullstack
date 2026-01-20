namespace View.models
{
    public class Carro
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public string Marca { get; set; }
        public int Ano { get; set; }
        public string Chassis { get; set; }
        public DateOnly PrimeiraAparicao { get; set; }
        public double Ipva { get; set; }
        public int Unidades { get; set; }
        public string Curiosidade { get; set; }
        public string Pais { get; set; }
        public string Motor { get; set; }
        public string Popularidade { get; set; }
        
    }
}