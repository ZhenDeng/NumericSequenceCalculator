using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NumericSequenceCalculator.Models;
using NumericSequenceCalculator.Services;

namespace NumericSequenceCalculator.Controllers
{
    public class HomeController : Controller
    {
        private readonly INumericSequenceCalculatorService calculatorService;

        public HomeController(INumericSequenceCalculatorService calculatorService)
        {
            this.calculatorService = calculatorService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CalculatorModel cm)
        {
            if (ModelState.IsValid)
            {
                this.calculatorService.CalculateSequence(cm);
            }

            return View(cm);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
