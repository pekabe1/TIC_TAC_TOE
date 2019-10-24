using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tic_Tac_Toe.Helpers.AbstractFactory;
using Tic_Tac_Toe.Helpers.Builder;

namespace Tic_Tac_Toe.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Small()
        {
            var director = new Director(BuilderFactory.GetBuilder(nameof(Small).ToLower()));
            director.Construct();
            return View(director.GetBoard);
        }
        public IActionResult Medium()
        {
            string methodBase = MethodBase.GetCurrentMethod().Name;
            var director = new Director( BuilderFactory.GetBuilder(methodBase));
            director.Construct();
            return View(director.GetBoard);
        }
        public IActionResult retuenView(string method)
        {
            
            var director = new Director(BuilderFactory.GetBuilder(method));
            director.Construct();
            return View(director.GetBoard);
        }

    }
}