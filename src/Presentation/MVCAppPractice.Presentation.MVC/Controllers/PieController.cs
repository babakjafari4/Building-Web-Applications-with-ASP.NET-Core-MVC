using System;
using Microsoft.AspNetCore.Mvc;

namespace MVCAppPractice.Presentation.MVC.Controllers
{
    public class PieController:Controller
    {
        public PieController()
        {
            
        }

        public IActionResult Index()
        {
            return Ok("Hello from pie controller. this is another test.");
        }
    }
}