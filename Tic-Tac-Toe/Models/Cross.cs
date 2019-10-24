using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tic_Tac_Toe.Helpers.FactoryMethod;

namespace Tic_Tac_Toe.Models
{
    public class Cross:Shape
    {
        public Line LineLeft { get; set; }
        public Line LineRight { get; set; }
        public int Color{ get; set; }
        public override Shape CreateShape()
        {
            LineLeft = new Line(0, Width);
            LineRight = new Line(Width, Height);
            return base.CreateShape();
        }

    }
}
