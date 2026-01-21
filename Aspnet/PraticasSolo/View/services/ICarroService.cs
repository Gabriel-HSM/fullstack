using View.models;

namespace View.services
{
    //O que é possivel fazer com o objeto Carro?
    public interface ICarroService
    {
        Task<IEnumerable<Carro>> ObterTodosCarros();
    }
}