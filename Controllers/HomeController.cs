using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Computer_Store.Models;
using Computer_Store.Entities;

namespace Computer_Store.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index(int Id)
    {
        using (var context=new StoreDBContext())
        {
            var item=context.ItemDetails.ToList();
             return View(item);
        }
         
    }

    public IActionResult Privacy()
    {
         return RedirectToAction(actionName: "Index", controllerName: "Home");
    }
    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
