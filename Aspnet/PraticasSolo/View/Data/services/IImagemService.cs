namespace View.Data.services
{
    public interface IImagemService
    {
        Task<string> SalvarImagemAsync(IFormFile imagemArquivo);
        
    }
}