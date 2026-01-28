using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace View.models
{
    public class Carro
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "O nome do carro não pode ser vazio.")]
        [StringLength(100, MinimumLength =3, ErrorMessage = "O nome do carro deve ter entre 3 e 100 caracteres.")]
        public string Nome { get; set; } = null!;
        [Required(ErrorMessage = "O preço do carro não pode ser vazio.")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }
        public int? MarcaId { get; set; }
        public Marca? Marca { get; set; }
        public int? MotorId { get; set; }
        public Motor? Motor { get; set; }
        public int? Ano { get; set; }
        public string? Chassis { get; set; }
        public DateOnly? PrimeiraAparicao { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Ipva { get; set; }
        public int? Unidades { get; set; }
        public string? Curiosidade { get; set; }
        public string? Pais { get; set; }
        public string? Popularidade { get; set; }
        public string? Imagem { get; set; }
        
        public Carro(){}
        public Carro(
            Guid id,
            string nome,
            decimal preco,
            int ano,
            string chassis,
            DateOnly primeiraAparicao,
            decimal ipva,
            int unidades,
            string curiosidade,
            string pais,
            string popularidade,
            string imagem)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            Ano = ano;
            Chassis = chassis;
            PrimeiraAparicao = primeiraAparicao;
            Ipva = ipva;
            Unidades = unidades;
            Curiosidade = curiosidade;
            Pais = pais;
            Popularidade = popularidade;
            Imagem = imagem;
        }
    }
}