using System.ComponentModel.DataAnnotations.Schema;

namespace View.models
{
    public class Carro
    {
        public Guid Id { get; set; }
        public string Nome { get; set; } = null!;
        [Column(TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }
        public string? Marca { get; set; }
        public int? Ano { get; set; }
        public string? Chassis { get; set; }
        public DateOnly? PrimeiraAparicao { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Ipva { get; set; }
        public int? Unidades { get; set; }
        public string? Curiosidade { get; set; }
        public string? Pais { get; set; }
        public string? Motor { get; set; }
        public string? Popularidade { get; set; }
        public string? Imagem { get; set; }
        
        public Carro(){}
        public Carro(
            Guid id,
            string nome,
            decimal preco,
            string marca,
            int ano,
            string chassis,
            DateOnly primeiraAparicao,
            decimal ipva,
            int unidades,
            string curiosidade,
            string pais,
            string motor,
            string popularidade,
            string imagem)
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
            Imagem = imagem;
        }
    }
}