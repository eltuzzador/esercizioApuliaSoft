using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;
using Esercizio1.Models.ViewModels;
using Esercizio1.Models.Services.Application;
using esercizio1.Models.Services.Application;
namespace esercizio1.Controllers
{

    public class HomeController : Controller
    {
        private readonly IEsercizio1Service esercizio1Service;

        public HomeController(IEsercizio1Service esercizio1Service)
        {//il parametro di input di questo metodo è una interfaccia. questo rende il tutto più flessibile a diverse esigenze
         //in tal senso si potranno usare diverse provenienze per i dati (ad esempio db)
            this.esercizio1Service = esercizio1Service;

        }
        public IActionResult Index()
        {//presenta l'elenco completo dei dati
        
            // var esercizio1Service=new Esercizio1Service();//i dati vanno presi da un database
            //List<Esercizio1ViewModel> data= esercizio1Service.GetServices();
            List<Esercizio1ViewModel> data = esercizio1Service.getTuple(); //elenco di tutti i dati disponibili
            return View(data);

            //return View();  //asp.net core mvc cercherà una view che segue le convenzioni. Che si chiama index.cshtml contenuta all'interno di views/esercizio1


        }
    }
}