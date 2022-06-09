using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewModel_Fun.Models;
namespace ViewModel_Fun.Controllers;

public class ViewModel : Controller
{

    [HttpGet("")]
    public ViewResult Main()
    {
        return View("Main", "This is some good Content");
    }
    [HttpGet("numbers")]
    public ViewResult Numbers()
    {
        return View("Numbers", new int[] { 1, 2, 3, 4, 5 });
    }
    [HttpGet("users")]
    public ViewResult Users()
    {
        List<User> myUsers = new List<User>(){new User("Michael", "Mason"), new Models.User("Tom", "Jones")};
        return View("Users", myUsers);
    }
    [HttpGet("user")]
    public ViewResult User()
    {
        User myUser = new User("Michael", "Mason");
        return View("User", myUser);
    }
}