using Microsoft.EntityFrameworkCore;
using View.models;

namespace View.Data.services
{
    public class CarroService : ICarroService
    {
        private readonly ProjetoModeloAppContext _context;
        private readonly IImagemService _imagemService;
        public CarroService(ProjetoModeloAppContext context, IImagemService imagemService)
        {
            _context = context;
            _imagemService = imagemService;
        }
        public async Task Add(Carro carro, IFormFile imagemArquivo)
        {

            if (imagemArquivo != null)
            {
                carro.Imagem = await _imagemService.SalvarImagemAsync(imagemArquivo);
            }
           
            carro.Id = Guid.NewGuid();
            _context.Carro.Add(carro);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Carro>> ObterTodos()
        {
              var carros = await _context.Carro.ToListAsync();
              return carros;
        }

        public async Task Delete(Guid id)
        {
            var carro = await _context.Carro.FindAsync(id);

            if (carro == null)
            {
                throw new KeyNotFoundException($"Carro não encontrado, ou inexistente");
            }

            _context.Carro.Remove(carro);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(Guid id, Carro carroAtualizado, IFormFile? imagemArquivo)
        {
            var carro = await _context.Carro.FindAsync(id);

            if (carro == null)
            {
                 throw new KeyNotFoundException($"Carro não encontrado, ou inexistente");
            }

            carro.Nome = carroAtualizado.Nome;
            carro.Preco = carroAtualizado.Preco;
            carro.Marca = carroAtualizado.Marca;
            carro.Ano = carroAtualizado.Ano;
            carro.Chassis = carroAtualizado.Chassis;
            carro.PrimeiraAparicao = carroAtualizado.PrimeiraAparicao;
            carro.Ipva = carroAtualizado.Ipva;
            carro.Unidades = carroAtualizado.Unidades;
            carro.Curiosidade = carroAtualizado.Curiosidade;
            carro.Pais = carroAtualizado.Pais;
            carro.Motor = carroAtualizado.Motor;
            
            if (imagemArquivo != null)
            {
                carro.Imagem = await _imagemService.SalvarImagemAsync(imagemArquivo);
            }
            
            _context.Carro.Update(carro);
            await _context.SaveChangesAsync();
        }

        public async Task<Carro> ObterPorId(Guid id){
            
            var carro = await _context.Carro.FindAsync(id);
            
            if (carro == null)
            {
                 throw new KeyNotFoundException($"Carro não encontrado, ou inexistente");
            }
            return carro;
        }
        
    }
}