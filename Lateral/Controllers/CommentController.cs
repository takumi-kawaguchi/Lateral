using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lateral.Controllers
{
    public class CommentController : Controller
    {
        [Route("Comment/Detail")]
        public ActionResult Index()
        {
            return View();
        }

		//public ActionResult()
    }
}