using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LivrariaDDD.Web.Models;
using LivrariaDDD.Application.Interface;
using LivrariaDDD.Domain.Entities;

namespace LivrariaDDD.Web.Controllers
{
    public class HomeController : Controller
    {
        ILivroAppService _service;
        public HomeController(ILivroAppService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var ret = await _service.ConsultaCompleta();
            return View(ret);
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
