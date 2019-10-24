﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tic_Tac_Toe.Models;

namespace Tic_Tac_Toe.Helpers.Builder
{
    public class SmallBoardBuilder : Default
    {
        public SmallBoardBuilder( ) : base(3)
        {
        }
    }
}
