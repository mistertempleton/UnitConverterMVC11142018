using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ConversionCalculator.Models;

namespace ConversionCalculator.Controllers
{
    public class ConversionController : Controller
    {
        public IActionResult Index()
        {
            string message = "this is the message";
            ViewData["Message"] = message;            
            return View();
        }
        public IActionResult Converter()
        {

            return View();
        }

        [HttpPost]
        public IActionResult DoConversion(ConverterViewModel model)
        {
            //the conversion work happens in here
            model.ConvertedValue = model.ValueToConvert * model.ValueToConvert;
            return View(model);
        }        

    }
}