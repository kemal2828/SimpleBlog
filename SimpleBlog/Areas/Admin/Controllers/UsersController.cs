using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog.Areas.Admin.Controllers
{
    public class UsersController : Controller
    {
        //
        // GET: /Admin/Users/
        public ActionResult Index()
        {
            return Content("Admin area users controller index action");
        }
        public ActionResult List()
        {
            return Content("Admin area users controller list action");
        }
        public ActionResult Edit(int id = 0)
        {
            return Content("Admin area users controller edit action"+id);
        }
	}
}