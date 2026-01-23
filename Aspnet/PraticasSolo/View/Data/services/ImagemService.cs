using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;

namespace View.Data.services
{
    public class ImagemService : IImagemService
    {
        private const int Largura = 768;
        private const int Altura = 512;
        public async Task<string> SalvarImagemAsync(IFormFile imagemArquivo)
        {
            if (imagemArquivo == null || imagemArquivo.Length == 0){
                throw new ArgumentException("Arquivo de imagem inválido.");
            }

            var extensao = Path.GetExtension(imagemArquivo.FileName).ToLowerInvariant();
            var nomeArquivo = $"{Guid.NewGuid()}{extensao}";
            var pasta = Path.Combine("wwwroot", "uploads");

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            var caminhoCompleto = Path.Combine(pasta, nomeArquivo);

            using var image = await Image.LoadAsync(imagemArquivo.OpenReadStream());

            image.Mutate(x =>
                x.Resize(new ResizeOptions
                {
                    Size = new Size(Largura, Altura),
                    Mode = ResizeMode.Max // mantém proporção EXATA e ajusta sem cortar
                })

                
            );

            await image.SaveAsync(caminhoCompleto);
            return $"/uploads/{nomeArquivo}";
        }
    }
}