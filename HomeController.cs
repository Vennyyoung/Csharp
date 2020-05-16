using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using sqrtChecker.Models;

namespace sqrtChecker.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;

        public HomeController (ILogger<HomeController> logger) {
            _logger = logger;
        }

        public IActionResult Index () {
            return View ();
        }
[HttpPost]
 public IActionResult SqrtChecker(string firstValue, string secondValue){
     viewBag.Result = realSqrd(string firstValue, secondValue);
            return View ();
        }

     private static string realSqrd(string firstNum, string secondNum){
         int firstValue;
         int secondValue;
         string present;
         bool convertFirst = int.parse(firstNum, out firstNum);
         bool convertSecond = int.parse(secondNum, out secondNum);
         
         
         if(firstNum == "" || secondNum == ""){
             present = "Please Enter a Number";
     }
     
     else if (convertFirst && ConvertSecond){
         if(firstValue < 0 || secondValue < 0){
             present = "Math Error! Enter a positive value";}
         else{
             double Sqr1st = Math.Sqrt(firstValue);
             double Sqr2nd = Math.Sqrt(secondValue);

                    if (Sqr1st > Sqr2nd) {
                        present = "The number " + firstValue + " with Square root " + Sqr1st + " has a Higher square root than the number " + secondValue + " with square root " + Sqr2nd";
                    }
                    else if (Sqr1st < Sqr2nd) {
                        present = "The number " + secondvalue + " with Square root " + Sqr2nd + " has a Higher square root than the number " + firstvalue + " with square root " + Sqr1st;
                    }
                    else if (Sqr1st == Sqr2nd) {
                        present = "Equal Values. Please enter different values";
                    }
                }
            }
            else {
                present = "Invalid! Please enter a valid value";
            }

            return present;
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
