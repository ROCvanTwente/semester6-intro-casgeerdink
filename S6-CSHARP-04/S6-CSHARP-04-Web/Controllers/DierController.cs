using Microsoft.AspNetCore.Mvc;
using S6_CSHARP_04_Lib.Enums;
using S6_CSHARP_04_Lib.Models;

namespace S6_CSHARP_04_Web.Controllers;

public class DierController : Controller
{
    public IActionResult Index()
    {
        return View(Dier.AlleDieren);
    }

    [HttpPost]
    public IActionResult MaakGeluid(string name)
    {
        var dier = Dier.AlleDieren.FirstOrDefault(d => d.Name == name);
        dier?.MakeSound();
        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult Verplaats(string name, Direction direction, int stappen)
    {
        var dier = Dier.AlleDieren.FirstOrDefault(d => d.Name == name);
        dier?.Move(direction, stappen);
        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult Toevoegen(string name, string soort)
    {
        if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(soort))
        {
            return RedirectToAction("Index");
        }

        Dier nieuwDier = soort switch
        {
            "Hond" => new Hond(name, new Random().Next(5, 30)),
            "Kip" => new Kip(name, new Random().Next(1, 5)),
            "Varken" => new Varken(name, new Random().Next(50, 200)),
            "Kat" => new Kat(name, new Random().Next(3, 10)),
            "Paard" => new Paard(name, new Random().Next(100, 500)),
            _ => null
        };

        if (nieuwDier != null)
        {
            Dier.AlleDieren.Add(nieuwDier);
        }

        return RedirectToAction("Index");
    }
}