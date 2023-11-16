using Microsoft.AspNetCore.Mvc;
using PimTeste.Context;
using PimTeste.Models;


namespace PimTeste.Controllers
{
    public class LoginController : Controller
    {
        private readonly AppDbContext _context;

        public LoginController(AppDbContext context) 
        {
         _context = context;
        
        }



        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EntrarTeste(UsuarioLogin usuarioLogin)
        {
            try 
            {
             var usuario = _context.UsuariosLogin.FirstOrDefault(u => u.Email == usuarioLogin.Email && u.senha == usuarioLogin.senha);
               
                if (usuario != null)
                {
                    // Usuário encontrado, redirecione para a página principal
                    return RedirectToAction("Principal", "Home");
                }
                else
                {
                    TempData["MensagemErro"] = "Ops, Usuário e/ou senha incorretos. Por favor, tente novamente.";
                    return View("Index");
                }

            } catch (Exception ex) 
            {
                TempData["MensagemErro"] = $"Ops, ocorreu um erro. Detalhe do erro: {ex.Message}";
                return RedirectToAction("Index");
            }


        }



    }
}
