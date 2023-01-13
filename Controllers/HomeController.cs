using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mvc101.Models;

namespace Mvc101.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    // Action methods - represents home page
    // has its own view
    public IActionResult Index()
    {
        string[] days = { "Mon", "Tues", "Wed", "Thurs", "Fri", "Sat", "Sun" };
        ViewData["days"] = days;
        return View();
    }
    // represents privacy page 
    // http://localhost:5094/Home/Privacy 
    // Home represents controller Privacy represents action method
    // has its own view
    public IActionResult Privacy()
    {
        return View();
    }
    // creating my own action method for a view
    public IActionResult Bogus()
    {
        // Dictionary entry with key author value james bond
        ViewData["author"] = "James Bond";
        //gave it name Date that displays date.
        ViewBag.Date = DateTime.Now;
        ViewData["Date"] = DateTime.Now;
        string[] days = { "Mon", "Tues", "Wed", "Thurs", "Fri", "Sat", "Sun" };

        return View(days);
    }

    //error catcher
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
