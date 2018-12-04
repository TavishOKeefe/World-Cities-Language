using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using Data.Models;
namespace Data.Controllers
{
    public class CityController : Controller
    {
      [HttpGet("/City")]
      public ActionResult Index()
      {
        List<City> allCitys = City.GetAll();
         return View(allCitys);

      }
  

    }
  }
