using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web3Lab.Models;

namespace Web3Lab.Controllers
{
    public class QuizController : Controller
    {
        [HttpGet]
        public IActionResult Quiz()
        {
            return View(new Quiz());
        }

        [HttpPost]
        public IActionResult Quiz(Quiz operation, string action)
        {
            if (ModelState.IsValid)
            {
                if (operation.CheckAnswer())
                    Answer.Instance.correctAnswer++;

                Answer.Instance.answers.Add(operation);
                //Answers.Instance.Add(operation);
            }
            else
            {
                ModelState.AddModelError("YourAnswer", "недопустимый формат ответа");
                return View(operation);
            }

            if (action == "Next")
                return View(new Quiz());

            return RedirectToAction("QuizResult");

        }

        public IActionResult QuizResult()
        {
            return View(Answer.Instance);
        }
    }
}