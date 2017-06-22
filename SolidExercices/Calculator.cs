using System;
using System.Linq;

namespace SolidExercices
{
    public class Calculator
    {
        public double Calculate(string operation)
        {
            if (operation.Contains('+'))
            {
                string[] splitOperation = operation.Split('+');
                return Convert.ToDouble(splitOperation[0]) + Convert.ToDouble(splitOperation[1]);
            }
            else if (operation.Contains('-'))
            {
                string[] splitOperation = operation.Split('-');
                return Convert.ToDouble(splitOperation[0]) - Convert.ToDouble(splitOperation[1]);
            }
            else if (operation.Contains('x'))
            {
                string[] splitOperation = operation.Split('x');
                return Convert.ToDouble(splitOperation[0]) * Convert.ToDouble(splitOperation[1]);
            }
            else if (operation.Contains('/'))
            {
                string[] splitOperation = operation.Split('/');
                /*
                if (Convert.ToDouble(splitOperation[0]) == 0 || Convert.ToDouble(splitOperation[1]) == 0)
                {
                    throw ImpossibleOperation("Impossible to divide a number by 0");
                }
                */
                return Convert.ToDouble(splitOperation[0]) / Convert.ToDouble(splitOperation[1]);
            }
            else
            {
                return 0;
            }
            //throw new NotImplementedException();
        }

    }
}