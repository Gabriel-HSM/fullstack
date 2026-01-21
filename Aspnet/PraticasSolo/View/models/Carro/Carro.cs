using models.valueObjects;
using View.models.valueObjects;

namespace View.models
{
    public class Carro
    {
        public Guid Id { get; set; }
        public CarroNome Nome { get; set; }
        public CarroPreco Preco { get; set; }
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
        
        public Carro(
            Guid id,
            CarroNome nome,
            CarroPreco preco,
            string marca,
            int ano,
            string chassis,
            DateOnly primeiraAparicao,
            double ipva,
            int unidades,
            string curiosidade,
            string pais,
            string motor,
            string popularidade)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            Marca = marca;
            Ano = ano;
            Chassis = chassis;
            PrimeiraAparicao = primeiraAparicao;
            Ipva = ipva;
            Unidades = unidades;
            Curiosidade = curiosidade;
            Pais = pais;
            Motor = motor;
            Popularidade = popularidade;
        }
    }
}