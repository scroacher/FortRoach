using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FortRoach.Controllers
{
    public class DudeController : Controller
    {
        [HttpGet("dude/{dude}")]
        public string Dude(string dude)
        {
            switch(dude)
            {
                case "bill":
                    return "Brah!";
                case "steve":
                    return "Bro.";
            }

            return String.Empty;
        }

        [HttpGet("dude/all")]
        public IActionResult All()
        {
            return View();
        }
    }
}
