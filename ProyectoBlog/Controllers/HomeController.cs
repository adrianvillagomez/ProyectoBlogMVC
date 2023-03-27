using Microsoft.AspNetCore.Mvc;
using ProyectoBlog.Models;
using ProyectoBlog.Rules;
using System.Diagnostics;

namespace ProyectoBlog.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Suerte()
		{
			var postRule= new PublicacionRule();
			var post = postRule.GetOnePostRandom();
			return View(post);
		}
		public IActionResult AcercaDe()
		{
			return View();
		}
		public IActionResult Contacto()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}