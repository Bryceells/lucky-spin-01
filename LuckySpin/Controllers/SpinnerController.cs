using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LuckySpin.Controllers
{
    public class SpinnerController : Controller
    {

        public IActionResult Index(int luck) 
        {
            //TODO: add your string builder and HTML from Exercise 0 here


            //TODO: Modify this to use the string builder's response string as the Content property's value
            return new ContentResult { Content = "<h1>We're Ready to Spin with Controllers</h1>", ContentType="text/html"};
        }
    }
}