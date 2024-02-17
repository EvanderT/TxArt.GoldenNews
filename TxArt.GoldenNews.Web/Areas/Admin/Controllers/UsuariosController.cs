using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TxArt.GoldenNews.Data.Repositories.Interfaces;

namespace TxArt.GoldenNews.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UsuariosController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuariosController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [Route("/Admin/Usuarios")]
        public IActionResult Index()
        {
            return View(_usuarioRepository.BuscarTodos());
        }
        public IActionResult Adicionar()
        {
            return View();
        }

    }
}
