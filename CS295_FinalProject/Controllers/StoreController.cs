using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CS295_FinalProject.Models;

namespace CS295_FinalProject.Controllers;

public class StoreController : Controller
{
    private readonly ILogger<StoreController> _logger;

    public StoreController(ILogger<StoreController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Reviews()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}