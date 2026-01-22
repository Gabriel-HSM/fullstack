using Microsoft.AspNetCore.Mvc;
using View.Data;
using View.models;

namespace MyApp.Namespace
{
    public class CarroController : Controller
    {
        //Apenas leitura do contexto do bd
        private readonly ProjetoModeloAppContext _context;
        public CarroController(ProjetoModeloAppContext contexto)
        {
            _context = contexto;
        }
        public ActionResult Index()
        {
            var carros = _context.Carro.ToList();
            return View(carros);
        }

        //View da página de Criar
        public IActionResult Create()
        {
            return View();
        }

        //Metodo que cria no banco de dados
        [HttpPost]
        public IActionResult Create(Carro carro, IFormFile imagemArquivo)
        {
            if (!ModelState.IsValid)
                return View(carro);

            if (imagemArquivo != null && imagemArquivo.Length > 0)
            {
                var pastaUploads = Path.Combine(
                    Directory.GetCurrentDirectory(),
                    "wwwroot/uploads"
                );

                if (!Directory.Exists(pastaUploads))
                    Directory.CreateDirectory(pastaUploads);

                var nomeArquivo = Guid.NewGuid() + Path.GetExtension(imagemArquivo.FileName);
                var caminhoCompleto = Path.Combine(pastaUploads, nomeArquivo);

                using (var stream = new FileStream(caminhoCompleto, FileMode.Create))
                {
                    imagemArquivo.CopyTo(stream);
                }

                carro.Imagem = "uploads/" + nomeArquivo; // isso vai pro banco
            }

            carro.Id = Guid.NewGuid();
            _context.Carro.Add(carro);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
