using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers
{
    [Authorize]
    public class FeedbackController : Controller
    {
        private IFeedbackRepository _repo;

        public FeedbackController(IFeedbackRepository repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                _repo.AddFeedback(feedback);
                return RedirectToAction("FeedbackComplete");
            }
            return View();
        }

        public IActionResult FeedbackComplete()
        {
            return View();
        }
    }
}