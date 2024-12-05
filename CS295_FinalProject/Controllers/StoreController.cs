using System.Diagnostics;
using CS295_FinalProject.Data;
using Microsoft.AspNetCore.Mvc;
using CS295_FinalProject.Models;

namespace CS295_FinalProject.Controllers;

public class StoreController : Controller
{
    private readonly IReviewRepository _repo;

    public StoreController(IReviewRepository r)
    {
        _repo = r;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Reviews()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Reviews(Review model)
    {
        model.Date = DateTime.Now;  // Add date and time to the model
        if (_repo.StoreReview(model) > 0)
        {
            return RedirectToAction("Index", new { reviewId = model.Id });
        }
        else
        {
            ViewBag.ErrorMessage = "There was an error saving the review.";
            return View();
        }
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}