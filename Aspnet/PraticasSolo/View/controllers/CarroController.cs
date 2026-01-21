using Microsoft.AspNetCore.Mvc;
using View.Data;

namespace MyApp.Namespace
{
    public class CarroController : Controller
    {
        //APenas leitura do contexto do bd
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

    }
}
