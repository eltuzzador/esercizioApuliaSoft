using Microsoft.AspNetCore.Mvc;


namespace esercizio1.Controllers{

public class HomeController:Controller{
    public IActionResult Index(){
        return View("Views/Home/Index.cshtml");
    }
}
}