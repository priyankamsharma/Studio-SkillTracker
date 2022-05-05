using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SkillsTracker.Controllers
{
    [Route("/skills/")]
    public class SkillsController : Controller
    {
        //GET :/<controller>
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<h1 title='Skills Tracker'>Skills Tracker</h1>" +
                               "<h2>Coding Skiils to learn</h2>" +
                               "<ol>" +
                                    "<li>C#</li>" +
                                    "<li>JavaScript</li>" +
                                    "<li>Python</li>" +
                               "</ol>";

            return Content(html, "text/html");
        }

        [HttpGet("/skills/form")]
        //[HttpPost]

        public IActionResult SkillForm()
        {
            string html = "<form method='post'>" +
                "<label for='date'>Date:</label>" + 
                "<br>" +
                    "<input type='date' name='date'>" + 
                    "<br>" +
                "<label for='C#'>C#:</label>" + 
                "<br>" +
                    "<select name = 'CSharp'>" +
                            "<option value='beginner'> Beginner </option >" +
                            "<option value='intermediate'> Intermediate </option>" +
                            "<option value='advance'> Advance </option >" +
                    "</select>" + 
                    "<br>" +
                "<label for='JavaScript'>JavaScript:</label>" +
                    "<br>" +
                    "<select name='JavaScript'>" +
                            "<option value='beginner'> Beginner </option >" +
                            "<option value='intermediate'> Intermediate </option>" +
                            "<option value='advance'> Advance </option >" +
                    "</select>" + 
                    "<br>" +
                "<label for='Python'>Python:</label>" + "<br>" +
                    "<select name = 'Python'>" +
                            "<option value='beginner'> Beginner </option >" +
                            "<option value='intermediate'> Intermediate </option>" +
                            "<option value='advance'> Advance </option >" +
                    "</select>" + 
                    "<br>" +
                "<input type='submit' value='Submit' />" +
              "</form>";

            return Content(html, "text/html");
        }

        [HttpPost("/skills/form")]

        public IActionResult FormPost(string date, string CSharp, string JavaScript, string Python )
        {
            string html = $"<h1 title='Skills Tracker'>Skills Tracker</h1>" +
                   $"<h2>{date}</h2>" +
                   "<ol>" +
                        $"<li>C#: {CSharp}</li>" +
                        $"<li>JavaScript: {JavaScript}</li>" +
                        $"<li>Python : {Python}</li>" +
                   "</ol>";

            return Content(html, "text/html");
        }

    }
}
