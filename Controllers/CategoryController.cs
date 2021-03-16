using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CIS4290SeniorProjectSpring2021.Models;
using System.Web.Mvc;

namespace CIS4290SeniorProjectSpring2021.Controllers
{
    public class CategoryController : Controller
    {
        private ConnectionStringforOnlineStore db = new ConnectionStringforOnlineStore();
        // GET: Category
        public ActionResult Index()
        {
            return View(db.Categories.ToList());
        }
    }
}