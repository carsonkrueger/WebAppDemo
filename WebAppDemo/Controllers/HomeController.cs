using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebAppDemo.Models;

namespace WebAppDemo.Controllers;

public class HomeController : Controller
{
    private static readonly IList<CommentModel> _comments;

    static HomeController()
    {
        _comments = new List<CommentModel>
        {
            new CommentModel
            {
                Id = 1,
                Author = "Carson Krueger",
                Text = "This is text"
            },
            new CommentModel
            {
                Id = 2,
                Author = "George Bush",
                Text = "This is cooler text"
            },
            new CommentModel
            {
                Id = 3,
                Author = "Jalapeno Business",
                Text = "This is poggers text"
            },
        };
    }

    public IActionResult GetUsers()
    {
        using (var context = new UsersContext())
        {
            return Json(context.Users.ToList());
        }
    }

    public IActionResult Index()
    {
        return View();
    }

    [Route("comments")]
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Comments()
    {
        return Json(_comments);
    }
}
