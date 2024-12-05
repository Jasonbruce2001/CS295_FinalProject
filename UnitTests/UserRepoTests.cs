using CS295_FinalProject.Controllers;
using CS295_FinalProject.Data;
using CS295_FinalProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace UnitTests;

public class ReviewControllerTests
{
    IReviewRepository _repo = new FakeReviewRepository.FakeReview();
    StoreController _controller;
    Review _review = new Review();

    public ReviewControllerTests()
    {
        _controller = new StoreController(_repo);
    }


    [Fact]
    public void Review_PostTest_Success()
    {
        // arrange: done in the constructor

        // act
        _review.Reviewer = new User();
        var result = _controller.Reviews(new Review());

        // assert: check to see if I got a RedirectToActionResult
        Assert.True(result.GetType() == typeof(RedirectToActionResult));
    }


    [Fact]
    public void Review_PostTest_Failure()
    {
        // arrange: done in the constructor

        // act
        var result = _controller.Reviews(_review);

        // assert: check to see if I got a RedirectToActionResult
        Assert.True(result.GetType() == typeof(ViewResult));
    }
}

