using Microsoft.AspNetCore.Mvc;
using PizzeriaWebApp.Models;
using PizzeriaWebApp.Utils;

namespace PizzeriaWebApp.Controllers
{
    public class PizzeController : Controller
    {
        [HttpGet]
        public IActionResult LeMiePizze()
        {
            List<Pizza> pizzas = PizzaData.GetPizza();
            return View(pizzas);
        }

        [HttpGet]
        public IActionResult Index()
        {
            
            return View();

        }
    }

    
}
