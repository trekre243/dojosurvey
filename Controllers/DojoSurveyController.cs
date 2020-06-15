using Microsoft.AspNetCore.Mvc;
using System;
using DojoSurvey.Models;

namespace DojoSurvey.Controllers
{
    public class DojoSurveyController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View("index");
        }

        [HttpPost("survey/create")]
        public IActionResult Create(Survey response)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Result", response);
            }
            else
            {
                return View("index");
            }
        }

        [HttpGet("result")]
        public IActionResult Result(Survey response)
        {
            return View("result", response);
        }

    }
}