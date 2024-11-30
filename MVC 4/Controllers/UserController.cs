using Microsoft.AspNetCore.Mvc;

namespace MVC_4.Controllers
{
    public class User : Controller {
        [HttpGet]
        public IActionResult Info(string name, string color)
        {
            var users = new Dictionary<string, string>
            { 
                { "Alice", "Alice is a software engineer specializing in web development." },
                { "Bob", "Bob is a data scientist with a passion for machine learning." },
                { "Charlie", "Charlie is a project manager with experience in IT and software projects." } 
            };
            if (string.IsNullOrEmpty(name) || !users.ContainsKey(name)) 
            { 
                    return Content("Error");
            }

            string userInfo = users[name];

            string style = "";
            if (!string.IsNullOrEmpty(color)) 
            {
                style = $"style='color: {color};'";
            }
            string content = $"<h1 {style}>{userInfo}</h1>";
            return Content(content, "text/html");
        }
    }
}