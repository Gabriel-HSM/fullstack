using View.models;

namespace View.Data.services
{
    public interface ICarroService
    {
        Task<IEnumerable<Carro>> ObterTodos();
        Task Add(Carro carro, IFormFile imagemArquivo);
        Task Delete(Guid id);
        Task<Carro> ObterPorId(Guid id);
        Task Edit(Guid id, Carro carro, IFormFile imagemArquivo);
        
    }
}