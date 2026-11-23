using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

//
// Name: Kerem Goldagi
// Class: ITD-2343-60486
// Trimester: Fall 2026
// Due Date: 11/18/2026
//

namespace Project5Goldagi
{
    public class ComparisonClass
    {
        public int dLeftNumber { get; set; } = 0;
        public int dRightNumber { get; set; } = 0;
        public int dNumberToCheck { get; set; } = 0;

        public ComparisonClass()
        {
                
        }

        public ComparisonClass(int leftNumber, int rightNumber, int numberToCheck)
        {
            dLeftNumber = leftNumber;
            dRightNumber = rightNumber;
            dNumberToCheck = numberToCheck;
        }

        public string GetComparison()
        {
            if (dNumberToCheck < dLeftNumber)
            {
                return $"{dNumberToCheck} is less than the lower bound ({dLeftNumber}). Go higher!";
            }
            else if (dNumberToCheck > dRightNumber)
            {
                return $"{dNumberToCheck} is greater than the upper bound ({dRightNumber}). Go lower!";
            }
            else if (dNumberToCheck == dLeftNumber || dNumberToCheck == dRightNumber)
            {
                return $"{dNumberToCheck} is equal to the lower bound ({dLeftNumber})";
            }
            else if (dNumberToCheck == dRightNumber)
            {
                return $"{dNumberToCheck} is equal to the upper bound ({dRightNumber})";
            }
            else
            {
                return $"{dNumberToCheck} is between the lower bound ({dLeftNumber}) and the upper bound ({dRightNumber})";
            }
        }
    }
}

