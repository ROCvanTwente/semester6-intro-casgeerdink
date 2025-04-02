using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using S6_CSHARP_01.Models;

namespace S6_CSHARP_01.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        string palindroom = "madam";
        string geenPalindroom = "hello";

        bool isPalindroom1 = palindroom.IsPalindrome();
        bool isPalindroom2 = geenPalindroom.IsPalindrome();
        
        ViewBag.Result1 = $"'{palindroom}' is een palindroom: {isPalindroom1}";
        ViewBag.Result2 = $"'{geenPalindroom}' is een palindroom: {isPalindroom2}";
        
        string test1 = "koffietijd";
        string test2 = "deze Zin kent wat VreemD Gebruik van HOOFDLETTERS";
        
        ViewBag.Test1 = $"Origineel: {test1} → Geformatteerd: {test1.FirstCharToUpper()}";
        ViewBag.Test2 = $"Origineel: {test2} → Geformatteerd: {test2.FirstCharToUpper()}";
        
        DateTime now = DateTime.Now;

        DateTime futureTime = now.AddMinutes(30);
        DateTime pastTime = now.AddMinutes(-15);

        ViewBag.FutureTime = $"Huidige tijd + 30 min: {futureTime}";
        ViewBag.PastTime = $"Huidige tijd - 15 min: {pastTime}";
        
        decimal bedrag = 1234.56m;

        ViewBag.Euro = bedrag.ToCurrencyString(CurrencyCountry.Euro);
        ViewBag.US = bedrag.ToCurrencyString(CurrencyCountry.UnitedStates);
        ViewBag.UK = bedrag.ToCurrencyString(CurrencyCountry.UnitedKingdom);
        ViewBag.Japan = bedrag.ToCurrencyString(CurrencyCountry.Japan);
        ViewBag.Onbekend = bedrag.ToCurrencyString((CurrencyCountry)999);
        
        int evenNumber = 4;
        int oddNumber = 7;

        ViewBag.EvenCheck = $"Is {evenNumber} even? {evenNumber.IsEven()}";
        ViewBag.OddCheck = $"Is {oddNumber} even? {oddNumber.IsEven()}";
        
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