using Microsoft.AspNetCore.Mvc;
using VendorOrderTracker.Models;
using System.Collections.Generic;

namespace VendorOrderTracker.Controllers
{
  public class OrdersController : Controller
  {

    [HttpGet("/orders")]
    public ActionResult Index()
    {
      List<Order> allOrders = Order.GetAll();
      return View(allOrders);
    }

    [HttpGet("/orders/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpGet("/orders/{id}")]
    public ActionResult Show(int id)
    {
      Order foundOrder = Order.Find(id);
      return View(foundOrder);
    }

    [HttpPost("/orders")]
    public ActionResult Create(string name, string description,  int price, string date)
    {
      Order myOrder = new Order(name, description, price, date);
      return RedirectToAction("Index");
    }

    [HttpPost("/orders/delete")]
    public ActionResult DeleteAll()
    {
      Order.ClearAll();
      return View();
    }
  }
}