using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanHang.Models;

namespace WebBanHang.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin,Employee")]
    public class AdvController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Admin/Adv
        public ActionResult Index()
        {
            return View();
        }
    }
}