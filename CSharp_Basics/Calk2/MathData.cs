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
            this.FirstNumber = firstNumber;  //gdybyśmy mieli tez z dużej litery to musimy użyć this.FirstNumber, czyli weź mie wartość z tej klasy
            // można tez uzyc nawet jak inne nazwy żeby było wiadomo
            SecondNumber = secondNumber;
            this.Operation = operation;
        }
    }
}
