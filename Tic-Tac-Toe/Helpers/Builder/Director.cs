using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tic_Tac_Toe.Models;

namespace Tic_Tac_Toe.Helpers.Builder
{
    public class Director
    {
        IBoardCreator builder;
        private SmallBoardBuilder smallBoardBuilder;

        public Director(IBoardCreator builder)
        {
            this.builder = builder;
        }
        public void Construct()
        {          
            builder.CreateRows();
            builder.AddCells();
   
        }
        public List<Row> GetBoard => builder.Rows; 
    }
}
