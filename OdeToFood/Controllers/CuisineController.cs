﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OdeToFood.Filters;

namespace OdeToFood.Controllers
{
    public class CuisineController : Controller
    {
        // GET: Cuisine
        // [Authorize]
        [Log]
        public ActionResult Search( string name = "french" )
        {
            throw new Exception( "Something terrible has happened" );
            var message = Server.HtmlEncode(name);

            return Content(message);

        }


    }
}