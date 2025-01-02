using Microsoft.AspNetCore.Mvc;
using MyIceDream.Models;
using System;
using System.Collections.Generic;
using MyIceDream.Models;
using MyIceDream.Areas.Identity.Data;
using System.Linq;

public class OrderController : Controller
{
    private readonly ApplicationDbContext _context;
    public OrderController(ApplicationDbContext context)
    {
        _context = context;
    }

   

    // GET: Order/Index
    public IActionResult Index()

    {
        List<Order> orders = _context.Orders.ToList();
        return View(orders);
    }
}
