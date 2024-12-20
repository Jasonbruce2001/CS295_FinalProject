using System.Diagnostics;
using CS295_FinalProject.Data;
using Microsoft.AspNetCore.Mvc;
using CS295_FinalProject.Models;

namespace CS295_FinalProject.Controllers;

public class GalleryController : Controller
{
    private readonly ILogger<GalleryController> _logger;
    private readonly ISubmissionRepository _subRepo;
    private readonly IUserRepository _userRepo;

    public GalleryController(ILogger<GalleryController> logger, ISubmissionRepository r, IUserRepository u)
    {
        _logger = logger;
        _subRepo = r;
        _userRepo = u;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Submissions()
    {
        List<Submission> submissions = _subRepo.GetAllSubmissions();
        return View(submissions);
    }

    public IActionResult SortOldest()
    {
        var submissions = _subRepo.GetAllSubmissions()
            .OrderBy(s => s.Date)
            .ToList();
        
        return View("Submissions", submissions);
    }

    public IActionResult SortNewest()
    {
        var submissions = _subRepo.GetAllSubmissions()
            .OrderByDescending(s => s.Date)
            .ToList();
        
        return View("Submissions", submissions);
    }
    
    [HttpPost]
    public IActionResult Index(Submission model)
    {
        model.Date = DateOnly.FromDateTime(DateTime.Today);  // Add date and time to the model
        
        if (_subRepo.StoreSubmission(model) > 0)
        {
            return View(_subRepo.GetAllSubmissions());
        }
        else
        {
            ViewBag.ErrorMessage = "There was an error saving your submission.";
            return View();
        }
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