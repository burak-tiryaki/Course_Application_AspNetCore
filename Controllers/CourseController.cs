using BurakAkademi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BurakAkademi.Controllers;

public class CourseController : Controller
{
    public IActionResult Index()
    {
        var model = Repository.Applications;
        return View(model);
    }

    public IActionResult Apply()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Apply(Candidate model)
    {
        if(Repository.Applications.Any(a => a.Email.Equals(model.Email)))
        {
            ModelState.AddModelError("","There is already an application for you.");
        }
        if(ModelState.IsValid)
        {
            Repository.Add(model);
            return View("Feedback",model);
        }
        return View();
        
    }
}