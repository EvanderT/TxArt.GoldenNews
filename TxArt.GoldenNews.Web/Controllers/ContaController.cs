using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TxArt.GoldenNews.Data.Entidades;
using TxArt.GoldenNews.Web.ViewModels.AutenticacaoAutorizacao;

namespace TxArt.GoldenNews.Web.Controllers
{
    public class ContaController : Controller
    {
        private readonly UserManager<Usuario> _userManager;
        private readonly SignInManager<Usuario> _signInManager;

        public ContaController(UserManager<Usuario> userManager, SignInManager<Usuario> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel viewModel)
        {
            if (ModelState.IsValid)
            {

                var user = await _userManager.FindByEmailAsync(viewModel.Usuario);
                if (user == null)
                {
                    user = await _userManager.FindByNameAsync(viewModel.Usuario);
                }

                if (user == null)
                {
                    ModelState.AddModelError(string.Empty, "Usuário ou Senha inválidos.");
                    return View(viewModel);
                }

                var result = await _signInManager.PasswordSignInAsync(user.UserName, viewModel.Senha, viewModel.Lembrar, lockoutOnFailure: false);

                if (result.Succeeded)
                {
                    var roles = await _userManager.GetRolesAsync(user);
                    if (roles.Contains("Admin"))
                    {
                        return RedirectToAction("Dashboard", "Home", new { area = "Admin" });
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home", new { area = "" });
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Usuário ou Senha inválidos.");
                    return View(viewModel);
                }
            }

            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
