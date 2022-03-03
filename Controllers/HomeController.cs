using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;
using Esercizio1.Models.ViewModels;
using Esercizio1.Models.Services.Application;

namespace esercizio1.Controllers{

public class HomeController:Controller{
    public IActionResult Index(){//presenta l'elenco completo dei dati
     var esercizio1Service=new Esercizio1Service();//ometto Esercizio1Service e inserisco var
//List<Esercizio1ViewModel> data= esercizio1Service.GetServices();
List<Esercizio1ViewModel> data=esercizio1Service.getServices(); //elenco dei dati disponibile
            return View(data); 
            
            //return View();  //asp.net core mvc cercherà una view che segue le convenzioni. Che si chiama index.cshtml contenuta all'interno di views/esercizio1
       
        
    }
}
}