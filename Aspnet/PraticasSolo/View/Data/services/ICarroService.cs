using View.models;
using View.models.PagedResult;

namespace View.Data.services
{
    public interface ICarroService
    {
        Task<IEnumerable<Carro>> ObterTodos();
        Task Add(Carro carro, IFormFile imagemArquivo);
        Task Delete(Guid id);
        Task<Carro> ObterPorId(Guid id);
        Task Edit(Guid id, Carro carro, IFormFile? imagemArquivo);
        Task<PagedResult<Carro>> ObterPaginadoAsync(int pagina, int tamanhoPagina);
        Task<IEnumerable<Marca>> ObterTodasMarcas();
        Task<IEnumerable<Motor>> ObterTodosMotores();
        
    }
}