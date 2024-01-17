﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MedicalScan.Models;

namespace MedicalScan.Controllers;

public class HomeController : Controller
{
private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }


    public IActionResult Index()
    {
        var specialities = _context.Specialities.ToList();
        return View(specialities);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}