using System.Linq;
using Microsoft.AspNetCore.Mvc;
using netcore_webapp.Models;
using netcore_webapp.ViewModels;

namespace netcore_webapp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        public IActionResult Index()
        {
           

            var pies = _pieRepository.GetAllPies().OrderBy(p => p.Name);

            var homeViewModel = new HomeViewModel()
            {
                Title = "Welcome to Eric's Pie Shop",
                Pies = pies.ToList()
            };

            return View(homeViewModel);
           
        }
    }
}