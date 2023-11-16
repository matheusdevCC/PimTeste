using Microsoft.AspNetCore.Mvc;

namespace PimTeste.Controllers
{
    public class FuncionarioController : Controller
    {
        public IActionResult CadastrarFuncionario()
        {
            return View("CadastrarFuncionario");
        
        
        }
    }
}
