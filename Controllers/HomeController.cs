using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Test_REPO.Models;
using System;

namespace Test_REPO.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        List<string> testList=new List<string>{"test"};
        Console.WriteLine(testList);

         try
            {
                // Empty catch block, which is a bug
                int x = 0;
                int y = 10 / x;
                return y;
            }
            catch (DivideByZeroException)
            {
            }
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
