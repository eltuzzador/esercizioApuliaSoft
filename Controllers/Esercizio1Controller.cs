
using Microsoft.AspNetCore.Mvc;

using Esercizio1.Models.Services.Application;
using System.Collections.Generic;
using Esercizio1.Models.ViewModels;
namespace esercizio1.Controllers
{

    public class Esercizio1Controller : Controller
    {

        public IActionResult Index()
        {return View("Views/esercizio1/Index.cshtml");
      }
        public IActionResult Detail(string id)
        {
            return View("Views/esercizio1/Detail.cshtml");
        }
    }

}