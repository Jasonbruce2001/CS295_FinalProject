using System.Diagnostics;
using CS295_FinalProject.Data;
using Microsoft.AspNetCore.Mvc;
using CS295_FinalProject.Models;

namespace CS295_FinalProject.Controllers;

public class StoreController : Controller
{
    private readonly IReviewRepository _reviewRepo;
    private readonly IProductRepository _productRepo;

    public StoreController(IReviewRepository r, IProductRepository p)
    {
        _reviewRepo = r;
        _productRepo = p;
    }

    public IActionResult Index()
    {
        List<Product> products = _productRepo.GetAllProducts();
        return View(products);
    }

    public IActionResult Reviews()
    {
        List<Review> reviews = _reviewRepo.GetAllReviews();
        return View(reviews);
    }
    
    public IActionResult ProductFilter(string name)
    {
        var products = _productRepo.GetAllProducts()
            .Where(p => name == null || p.Name.Contains(name))
            .ToList();
/*
            var reviews = repo.GetReviews()
                .Where(r => r.Reviewer.Name == reviewer|| reviewer == null)
                .ToList();*/
        return View("Index", products);
    }
    
    public IActionResult ReviewFilter(int score, string date)
    {
        var reviews = _reviewRepo.GetAllReviews()
            .Where(r => score == null || r.Score == score)
            .Where(r => date == null || r.Date ==  DateOnly.Parse(date))
            .ToList();
/*
            var reviews = repo.GetReviews()
                .Where(r => r.Reviewer.Name == reviewer|| reviewer == null)
                .ToList();*/
        return View("Reviews", reviews);
    }
    
    [HttpPost]
    public IActionResult Reviews(Review model)
    {
        model.Date = DateOnly.FromDateTime(DateTime.Today);  // Add date and time to the model
        if (_reviewRepo.StoreReview(model) > 0)
        {
            return View(_reviewRepo.GetAllReviews());
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