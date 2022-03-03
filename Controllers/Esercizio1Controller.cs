
using Microsoft.AspNetCore.Mvc;

namespace esercizio1.Controllers{

public class Esercizio1Controller:Controller{
    
    public IActionResult Index(){//presenta l'elenco completo dei dati
return View(); //asp.net core mvc cercherà una view che segue le convenzioni. Che si chiama index.cshtml contenuta all'interno di views/esercizio1
    }
    public IActionResult Detail(string id){
return View("Views/esercizio1/Detail.cshtml");
    }
}

}