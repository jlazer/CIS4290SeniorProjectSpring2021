using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CIS4290SeniorProjectSpring2021.Models;

namespace CIS4290SeniorProjectSpring2021.Controllers
{
    public class ProductController : Controller
    {
        // GET: ProductDetail
        public ActionResult Index()
        {
            return View();
        }
    }
}