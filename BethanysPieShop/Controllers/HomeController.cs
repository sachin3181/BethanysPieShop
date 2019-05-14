using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BethanysPieShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _repo;

        public HomeController(IPieRepository repo)
        {
            _repo = repo;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
           
            var pies = _repo.GetAllPies().OrderBy(p => p.Name);
            var homeVM = new HomeViewModel()
            {
                Title = "Welcome to Bethany's Pie Shop",
                Pies = pies.ToList()
            };
            return View(homeVM);
        }

        public IActionResult Details(int id)
        {
            var pie = _repo.GetPieById(id);
            if (pie == null)
            {
                return NotFound();
            }
            return View(pie);
        }
    }
}
