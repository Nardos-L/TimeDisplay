using System;
using Microsoft.AspNetCore.Mvc;

namespace  TimeDisplay
{
    public  class HomeController : Controller
    {
        //localhost:5000
        [HttpGet("")]
        public ViewResult Index()
        {
            

            return View("Index");
        }
    }
}