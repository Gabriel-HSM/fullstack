using Microsoft.AspNetCore.Mvc;
using View.Data.services;
using View.models;

namespace MyApp.Namespace
{
    public class CarroController : Controller
    {
        //Por boa prática, não se deve instanciar o contexto diretamente na controller, mas sim usar a interface do serviço. (Injeção de dependência) pois a interface possui os métodos necessários.
        private readonly ICarroService _carroService;
        public CarroController(ICarroService carroService)
        {
            _carroService = carroService;
        }

        //Assync porque pode demorar, e se demorar pode parar de funcionar, então isso pode permitir que tarefas funcionem em segundo plano sem que a thread principal pare.
        //await porque ele vai aguardar a tarefa ser concluída antes de continuar a execução do código.
        public async Task<ActionResult> Index()
        {
            var carros = await _carroService.ObterTodos();
            return View(carros);
        }

        //View da página de Criar
        public IActionResult Create()
        {
            return View();
        }

        //Metodo que cria no banco de dados
        [HttpPost]
        public async Task<IActionResult> Create(Carro carro, IFormFile imagemArquivo)
        {
            if (ModelState.IsValid)
            {
                await _carroService.Add(carro, imagemArquivo);
                return RedirectToAction("Index");
            }
                return View(carro);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _carroService.Delete(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var carro = await _carroService.ObterPorId(id);

            if (carro == null)
                return NotFound();

            return View(carro);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, Carro carroAtualizado, IFormFile? imagemArquivo)
        {
            if (ModelState.IsValid)
            {
                await _carroService.Edit(id, carroAtualizado, imagemArquivo);
                return RedirectToAction("Index");
            }
            Console.WriteLine("Model state is invalid.");
                return View(carroAtualizado);
        }
                

        

    }
}
