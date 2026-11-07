using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewLab.Models;

namespace ViewLab.Controllers;

public class TaskController: Controller
{
    public IActionResult Greetings()
    {
        return View();
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}