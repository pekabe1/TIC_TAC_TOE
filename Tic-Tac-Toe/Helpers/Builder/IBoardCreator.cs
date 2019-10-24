using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tic_Tac_Toe.Models;

namespace Tic_Tac_Toe.Helpers.Builder
{
   public interface IBoardCreator

    {
        List<Row> Rows { get; }
        void CreateRows ();
        Cell CreateCell(int i, Row row);
        Row CreateRow(int i);
        void AddCells();
    }
}
