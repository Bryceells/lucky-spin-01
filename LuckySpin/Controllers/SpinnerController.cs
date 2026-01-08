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
                Random random = new Random();
                int[] spin = new int[] { random.Next(10), random.Next(10), random.Next(10) };
                System.Text.StringBuilder htmlToShow =  
                    new System.Text.StringBuilder("<body><h1>Lucky Spin - by Bryce H, Vadym R, & Alex Y</h1><button onclick='history.go(0)'>Spin</button>");
                htmlToShow.Append("<div>" + spin[0] + "</div>");
                htmlToShow.Append("<div>" + spin[1] + "</div>");
                htmlToShow.Append("<div>" + spin[2] + "</div>");

                if (spin[0] == luck || spin[1] == luck || spin[2] == luck)
                {
                    htmlToShow.Append("<img src='http://studentfolders.cascadia.edu/itweb285/LuckySpinCoins.jpg'/></body>");
                }
 


            //TODO: Modify this to use the string builder's response string as the Content property's value
            return new ContentResult { Content = htmlToShow.ToString(), ContentType="text/html"};
        }
    }
}