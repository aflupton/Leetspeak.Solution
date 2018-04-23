using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Leetspeak.Models;

namespace Leetspeak.Controllers
{
  public class HomeController : Controller
    {
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }


    }
}
