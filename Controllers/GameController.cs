using DependencyInjectionDemo.Models;
using DependencyInjectionDemo.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace DependencyInjectionDemo.Controllers
{
    public class GameController : Controller
    {
        private readonly ILogger<GameController> _logger;
        private readonly IPlayerGenerator _playerGenerator;

        public GameController(ILogger<GameController> logger, IPlayerGenerator playerGenerator)
        {
            _logger = logger;
            _playerGenerator = playerGenerator;
        }

        public IActionResult Index()
        {
            var newPlayer = _playerGenerator.CreateNewPlayer();

            return View(newPlayer);
        }

        public IActionResult Privacy()
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
