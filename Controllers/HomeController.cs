﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization.Infrastructure;

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
        var specialities = _context.Specialities.OrderBy(d => d.Id).ToList();
        var doctors = _context.Doctors.Select(d => new Doctor {
            Id = d.Id,
            Name = d.Name,
            Specialities = d.Specialities.ToList()
        } ).OrderBy(d => d.Id).ToList();
        var model = new Tuple<List<Speciality>, List<Doctor>>(specialities, doctors);
        return View(model);
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
