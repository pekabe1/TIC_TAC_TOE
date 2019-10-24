using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tic_Tac_Toe.Helpers.FactoryMethod
{
    public abstract class Shape
    {
        public virtual Shape CreateShape()
        {
            return this; 
        }
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
