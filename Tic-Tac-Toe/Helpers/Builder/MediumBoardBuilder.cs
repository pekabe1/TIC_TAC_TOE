using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tic_Tac_Toe.Models;

namespace Tic_Tac_Toe.Helpers.Builder
{
    public class MediumBoardBuilder : IBoardCreator
    {
        public List<Row> Rows { get; } = new List<Row>();
        const int rowCount = 4;

        public void AddCells()
        {
            Rows.ForEach(r =>
            {
                List<Cell> cells = new List<Cell>();
                for (int i = 0; i < Rows.Count; i++)
                {
                    cells.Add(CreateCell(i, Rows[i]));
                }
                r.Cells = cells;
            });
        }
        public Cell CreateCell(int id, Row row)
        {
            return new Cell { Id = id, Row = row };
        }
        public Row CreateRow(int id)
        {
            return new Row { RowId = id };
        }
        public void CreateRows()
        {
            List<Row> rows = new List<Row>();
            for (int i = 0; i < rowCount; i++)
            {
                Rows.Add(CreateRow(i));
            }
        }
    }
}
