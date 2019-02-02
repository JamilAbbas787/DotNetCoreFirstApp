using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DotNetCoreFirstApp.Models;

namespace DotNetCoreFirstApp.Controllers
{
  public class CarsController : Controller
  {
    public IActionResult Index()
    {
      
      return View();
    }
  }
}