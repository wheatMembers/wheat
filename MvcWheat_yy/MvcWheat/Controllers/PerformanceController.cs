using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcWheat.Models;

namespace MvcWheat.Controllers
{
    public class PerformanceController : Controller
    {
        private PerformanceDBContext db = new PerformanceDBContext();

        //
        // GET: /Performance/

        public ActionResult SearchIndex()
        {
            return View(db.Performances.ToList());
        }

        //
        // GET: /Performance/Details/5
    }
}