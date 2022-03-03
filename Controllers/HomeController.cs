using Microsoft.AspNetCore.Mvc;


namespace esercizio1.Controllers{

public class HomeController:Controller{
    public IActionResult Index(){
        return Content("SOno la index della home");
    }
}
}