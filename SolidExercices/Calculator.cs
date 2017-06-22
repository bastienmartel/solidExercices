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
                double result = Convert.ToDouble(splitOperation[0]);
                for (int i = 1; i < splitOperation.Length ; i++)
                {
                    result += Convert.ToDouble(splitOperation[i]);
                }
                return result;
            }
            else if (operation.Contains('-'))
            {
                string[] splitOperation = operation.Split('-');
                double result = Convert.ToDouble(splitOperation[0]);
                for (int i = 1; i < splitOperation.Length; i++)
                {
                    result -= Convert.ToDouble(splitOperation[i]);
                }
                return result;
                
            }
            else if (operation.Contains('x'))
            {
                string[] splitOperation = operation.Split('x');
                double result = Convert.ToDouble(splitOperation[0]);
                for (int i = 1; i < splitOperation.Length; i++)
                {
                    result *= Convert.ToDouble(splitOperation[i]);
                }
                return result;
                
            }
            else if (operation.Contains('/'))
            {
                string[] splitOperation = operation.Split('/');
                double result = Convert.ToDouble(splitOperation[0]);
                if (Convert.ToDouble(splitOperation[0]) == 0 || Convert.ToDouble(splitOperation[1]) == 0)
                {
                    throw new Exception("Impossible to divide a number by 0");
                }
                for (int i = 1; i < splitOperation.Length; i++)
                {
                    result /= Convert.ToDouble(splitOperation[i]);
                }
                return result;
                
            }
            else
            {
                return 0;
            }
        }

    }
}