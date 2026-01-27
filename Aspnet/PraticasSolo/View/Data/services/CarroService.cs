using Microsoft.EntityFrameworkCore;
using View.models;
using View.models.PagedResult;

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

            //Imagem não pode ser nula no add
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
            carro.MarcaId = carroAtualizado.MarcaId;
            carro.Ano = carroAtualizado.Ano;
            carro.Chassis = carroAtualizado.Chassis;
            carro.PrimeiraAparicao = carroAtualizado.PrimeiraAparicao;
            carro.Ipva = carroAtualizado.Ipva;
            carro.Unidades = carroAtualizado.Unidades;
            carro.Curiosidade = carroAtualizado.Curiosidade;
            carro.Pais = carroAtualizado.Pais;
            carro.MotorId = carroAtualizado.MotorId;
            
            if (imagemArquivo != null)
            {
                carro.Imagem = await _imagemService.SalvarImagemAsync(imagemArquivo);
            }
            
            _context.Carro.Update(carro);
            await _context.SaveChangesAsync();
        }

        public async Task<Carro> ObterPorId(Guid id){
            
            var carro = await _context.Carro
            .Include(c => c.Marca)
            .Include(c => c.Motor)
            .FirstOrDefaultAsync(c => c.Id == id);
            
            if (carro == null)
            {
                 throw new KeyNotFoundException($"Carro não encontrado, ou inexistente");
            }
            return carro;
        }

        public async Task<PagedResult<Carro>> ObterPaginadoAsync(int page, int pageSize)
        {
            var query = _context.Carro.AsNoTracking()
            .Include(c => c.Marca)
            .Include(c => c.Motor);

            var totalItens = await query.CountAsync();
            var carros = await query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return new PagedResult<Carro>
            {
                Itens = carros,
                TotalItens = totalItens,
                PaginaAtual = page,
                PaginaTamanho = pageSize
            };
        }

        public async Task<IEnumerable<Marca>> ObterTodasMarcas()
        {
            return await _context.Marcas.ToListAsync();
        }

        public async Task<IEnumerable<Motor>> ObterTodosMotores()
        {
            return await _context.Motores.ToListAsync();
        }
        
    }
}