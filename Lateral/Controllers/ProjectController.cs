﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lateral.Controllers
{
    public class ProjectController : Controller
    {
        [Route("Project/Index")]
        public ActionResult Index()
        {
            return View();
        }

		
    }
}