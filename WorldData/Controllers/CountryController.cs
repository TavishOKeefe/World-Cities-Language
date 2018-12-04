using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using Data.Models;
namespace Data.Controllers
{
    public class CountryController : Controller
    {
      [HttpGet("/Country")]
      public ActionResult New()
      {
        List<Country> allCountrys = Country.GetAll();
         return View(allCountrys);

      }
    }
  }
