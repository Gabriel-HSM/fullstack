using Microsoft.AspNetCore.Mvc.RazorPages;

namespace View.Views.Carro
{
    public class Create : PageModel
    {
        private readonly ILogger<Create> _logger;

        public Create(ILogger<Create> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}