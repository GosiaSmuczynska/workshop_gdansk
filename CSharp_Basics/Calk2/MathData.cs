using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calk2
{
    public class MathData  //ale teraz nie dajemy słowa static
    {
        public int FirstNumber;
        public int SecondNumber;
        public string Operation;

        public MathData(int firstNumber, int secondNumber, string operation)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
            Operation = operation;
        }
    }
}
