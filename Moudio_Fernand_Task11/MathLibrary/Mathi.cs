using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class Mathi
    {
        public static int Factorial (int number)
        {
            int fact = 1;
            for (int i = 1; i<= number; i++)
            {
                fact *= i;
            }
            return fact;
        }

        public static double Power (double number, int pow)
        {
            double result = 1.0;
            if(pow == 0)
            {
                return 1.0;
            }
            else
            {
                for (int i = 1; i <= pow; i++)
                {
                    result *= number;
                }
            }
            return result;
        }

        public static int Power(int number, int pow)
        {
            int result = 1;
            if (pow == 0)
            {
                return 1;
            }
            else
            {
                for (int i = 1; i <= pow; i++)
                {
                    result *= number;
                }
            }
            return result;
        }
    }
}
