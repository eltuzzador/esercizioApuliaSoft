
using Microsoft.AspNetCore.Mvc;

namespace esercizio1.Controllers{

public class Esercizio1Controller:Controller{
    
    public IActionResult Index(){//presenta l'elenco completo dei dati
return Content("Sono Index");
    }
    public IActionResult Detail(string id){
return Content($"Sono Detail, ho ricevuto l'id{id}");
    }
}

}