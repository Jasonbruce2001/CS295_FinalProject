using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CS295_FinalProject.Models;

namespace CS295_FinalProject.Controllers;

public class GalleryController : Controller
{
    private readonly ILogger<GalleryController> _logger;

    public GalleryController(ILogger<GalleryController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Submissions()
    {
        return View();
    }

    public IActionResult Events()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}