using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ViewLab.Controllers;

public class TasksController: Controller
{
    private static readonly string[] Markets =
        { "WellMart", "Silpo", "ATB", "Furshet", "Metro" };

    private static Dictionary<string, int> GetShoppingList() => new Dictionary<string, int>
    {
        { "Milk", 2 },
        { "Bread", 2 },
        { "Cake", 1 },
        { "Ice Cream", 5 },
        { "Cola", 10 }
    };

    public IActionResult SprintTasks() => View();

    public IActionResult Greetings() => View();

    public IActionResult ProductInfo() => View();

    public IActionResult SuperMarkets()
    {
        ViewBag.Markets = Markets.ToList();
        return View();
    }

    public IActionResult ShoppingList() => View(GetShoppingList());

    [HttpGet]
    public IActionResult ShoppingCart()
    {
        ViewBag.Markets = new SelectList(Markets);
        ViewBag.Dates = Enumerable.Range(0, 3)
            .Select(i => DateTime.Today.AddDays(i))
            .ToList();
        ViewBag.Products = new MultiSelectList(GetShoppingList().Keys, new[] { "Milk" });
        return View();
    }

    [HttpPost]
    public IActionResult ShoppingCart(string fullName, string address,
        string market, DateTime shipDate, string[] products)
    {
        return Content($"Your products will be shipped at: {address}. Bon appetite, {fullName}!");
    }
}