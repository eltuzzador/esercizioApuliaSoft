
using Microsoft.AspNetCore.Mvc;

//using esercizio1.Models.Services.Application;
using System.Collections.Generic;
using Esercizio1.Models.ViewModels;
using Esercizio1.Models.Services.Application;
//using esercizio1.Models.Services.Application;
namespace esercizio1.Controllers
{

    public class Esercizio1Controller : Controller
    {
 private readonly IEsercizio1Service esercizio1Service;

        public Esercizio1Controller(IEsercizio1Service esercizio1Service)
        {//il parametro di input di questo metodo è una interfaccia. questo rende il tutto più flessibile a diverse esigenze
         //in tal senso si potranno usare diverse provenienze per i dati (ad esempio db)
            this.esercizio1Service = esercizio1Service;

        }
        public IActionResult Index()
        {
            return View("Views/esercizio1/Index.cshtml");
        }
        public IActionResult Detail()
        //group by progetto
        {List<Esercizio1ViewModel> data1 = esercizio1Service.getTuple("SELECT ID_Project, SUM(Ore) FROM SvoltoDa GROUP BY ID_Project ORDER BY ID_Project DESC"); //elenco di dati dal groyp by progetto
            return View(data1);
            
        }
        public IActionResult Detail1()
        //group by progetto
        {List<Esercizio1ViewModel> data2 = esercizio1Service.getTuple("SELECT ID_Project,ID_Employee, SUM(Ore)  FROM SvoltoDa GROUP BY ID_Project, ID_Employee ORDER BY ID_Project DESC"); //elenco di dati dal groyp by progetto impiegato
            return View(data2);
            
        }

        public IActionResult Detail2()
        //group by progetto
        {List<Esercizio1ViewModel> data2 = esercizio1Service.getTuple("SELECT ID_Employee,ID_Project, SUM(Ore)  FROM SvoltoDa GROUP BY ID_Employee,ID_Project ORDER BY ID_Project DESC"); //elenco di dati dal groyp by impiegato progetto
            return View(data2);
            
        }
        
    }

}