using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tic_Tac_Toe.Models
{
    public class Row
    {
      public  int RowId  { get; set; }
        public List<Cell> Cells { get; set; }
    }
}
