using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc01.Controllers
{
  public class SupportsController : Controller
  {
    // GET: Supports
    public ActionResult Index()
    {
      return View(); 
    }

    public ActionResult Faqs()
    {
      return View();
    }

    public ActionResult Team()
    {
      ViewBag.Names = "Suthep,Sukit,Supot,Surasit";
      ViewData["Colors"] = "Orange,Lavender,Beige,Yellow";
      ViewBag.Key = "Names";
      return View();
    }

  }
}