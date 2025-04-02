using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using S6_CSHARP_03_Lib;
using S6_CSHARP_03_Web.Models;

namespace S6_CSHARP_03_Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Dier hond = new Hond(20);
        Dier kip = new Kip(2);
        Dier varken = new Varken(150);

        hond.Geluid();
        kip.Geluid();
        varken.Geluid();

        ViewBag.HondInfo = $"Hond Gewicht: {hond.Gewicht} kg";
        ViewBag.KipInfo = $"Kip Gewicht: {kip.Gewicht} kg";
        ViewBag.VarkenInfo = $"Varken Gewicht: {varken.Gewicht} kg";

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