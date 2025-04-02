using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using S6_CSHARP_02_Web.Models;
using S6_CSHARP_02;

namespace S6_CSHARP_02_Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var myCar = new Car("Rood");
        var myBike = new Bicycle("Blauw");

        myCar.Accelerate(50);
        myBike.Accelerate(20);

        ViewBag.CarInfo = $"Auto: {myCar.Color}, {myCar.NumberOfWheels} wielen, {myCar.GetSpeed()}";
        ViewBag.BikeInfo = $"Fiets: {myBike.Color}, {myBike.NumberOfWheels} wielen, {myBike.GetSpeed()}";

        var rect = new Rectangle(10, 5);
        var circle = new Circle(7);

        rect.Resize(1.5);
        circle.Resize(2);

        ViewBag.RectangleInfo =
            $"Rechthoek: {rect.Width} x {rect.Height}, Oppervlakte: {rect.Area}, Omtrek: {rect.CalculatePerimeter()}";
        ViewBag.CircleInfo =
            $"Cirkel: Straal {circle.Radius}, Oppervlakte: {circle.Area}, Omtrek: {circle.CalculatePerimeter()}";
        
        
        Dog dog = new Dog("test", 10.5, 4);
        Cat cat = new Cat("kat", 4.2, 3);
        
        dog.ChangeName("hond");
        cat.ChangeAge(4);
        
        ViewBag.DogInfo = dog.GetAnimalInfo();
        ViewBag.CatInfo = cat.GetAnimalInfo();

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