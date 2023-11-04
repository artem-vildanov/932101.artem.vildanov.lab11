﻿using lab11.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace lab11.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult ModelCalc()
        {
            Random random = new Random();

            int randFirstValue = random.Next(1, 100);
            int randSecondValue = random.Next(1, 100);

            var Calc = new CalcViewModel
            {
                firstValue = randFirstValue,
                secondValue = randSecondValue,
                additionResult = randFirstValue + randSecondValue,
                subtractionResult = randFirstValue - randSecondValue,
                multiplicationResult = randFirstValue * randSecondValue,
                divisionResult = randFirstValue / randSecondValue,
            };

            return View(Calc);
        }

        public IActionResult ViewDataCalc()
        {
            return View();
        }

        public IActionResult ViewBagCalc()
        {
            return View();
        }

        public IActionResult ServiceInjCalc()
        {
            return View();
        }
    }
}
