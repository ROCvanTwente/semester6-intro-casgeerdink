using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using S6_CSHARP_04_Lib.Interfaces;
using S6_CSHARP_04_Lib.Models;
using S6_CSHARP_04_Web.Models;

namespace S6_CSHARP_04_Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        if (!Dier.AlleDieren.Any())
        {
            new Hond("hond1", 20);
            new Hond("hond2", 25);
            new Kip("kip1", 2);
            new Kip("kip2", 3);
            new Varken("varken1", 150);
            new Varken("varken2", 140);
            
        }
        
        foreach (var dier in Dier.AlleDieren)
        {
            dier.MakeSound();
        }

        ViewBag.DierenLijst = Dier.AlleDieren.Select(d => $"{d.Name}: {d.Position.X}, {d.Position.Y}").ToList();
        

        return View();
    }


    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}