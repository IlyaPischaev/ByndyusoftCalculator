using System;
using System.Collections.Generic;
using System.Text;

namespace ByndyusoftCalculator
{
    public class ReversePolishOperations
    {
        public bool IsStatement(char symbol)
        {
            if ("()+-/*".Contains(symbol)) return true;
            return false;
        }

        public bool IsStatement(string symbol)
        {
            if ("()+-/*".Contains(symbol)) return true;
            return false;
        }

        public int PriorityCheck(char symbol)
        {
            if ("+-".Contains(symbol)) return 2;
            else if ("/*".Contains(symbol)) return 3;
            return 1;
        }

        public bool IsNumberOrFractional(char symbol)
        {
            if (Char.IsNumber(symbol) || (symbol == ',')) return true;
            return false;
        }
    }
}
