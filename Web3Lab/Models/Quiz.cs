using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web3Lab.Models
{
    public class Quiz
    {
        public double firstValue { get; set; }
        public double secondValue { get; set; }
        public double answer { get; set; }
        public string operand { get; set; }

        public Quiz()
        {

            Random rnd = new Random();

            firstValue = rnd.Next(20);
            secondValue = rnd.Next(20);

            string[] operands = { "+", "-", "*", "/" };
            operand = operands[rnd.Next(4)];
        }


        public bool CheckAnswer()
        {
            double correctAnswer = default;
            switch (operand)
            {
                case "+":
                    correctAnswer = firstValue + secondValue;
                    break;
                case "-":
                    correctAnswer = firstValue - secondValue;
                    break;
                case "*":
                    correctAnswer = firstValue * secondValue;
                    break;
                case "/":
                    correctAnswer = firstValue / secondValue;
                    break;
            }

            return correctAnswer == answer ? true : false;
        }
    }
}
