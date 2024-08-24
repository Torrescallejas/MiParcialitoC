using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MiParcialitoC.Controllers
{
    public class CuentaController : Controller
    {
        // Acción para mostrar la vista de Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // Acción para manejar el envío del formulario de Login (opcional)
        [HttpPost]
        public IActionResult Login(string email, string password, bool rememberMe)
        {
            // Aquí puedes manejar la autenticación del usuario
            // y redirigir a la página correspondiente en caso de éxito
            return RedirectToAction("Index", "Home");
        }
    }
}
