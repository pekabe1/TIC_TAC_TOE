using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tic_Tac_Toe.Helpers.FactoryMethod;

namespace Tic_Tac_Toe.Models
{
    public class Circlem :Shape
    {
        public Line Line{ get; set; }
        public string Color{ get; set; }
        public override Shape CreateShape()
        {

            Color = "grey";
            Line = new Line(0,1)
            return base.CreateShape();
        }
    }
}

