using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tic_Tac_Toe.Models;

namespace Tic_Tac_Toe.Helpers.FactoryMethod
{
    public static class ShapeDrawer
    {
        public static Shape Draw(string name)
        {
            Shape shape = null;
            switch (name)
            {
                case "circle":
                    shape = new Circle().CreateShape();
                    break;

                case "cross":
                    shape = new Cross().CreateShape();
                    break;
                default:
                    throw new Exception("Invalid name");
            }
        }
    }
}
