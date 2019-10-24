using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tic_Tac_Toe.Helpers.Builder;

namespace Tic_Tac_Toe.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Small()
        {
            var director = new Director(new SmallBoardBuilder());
            director.Construct();
            return View(director.GetBoard);
        }
    }
}