using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalNumsLib
{
    public static class NaturalNumbers
    {
           
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
      
        public static int GCD(int A, int B) // greatest common divisor (GCD)
        {
            if(A < 0 || B < 0)
            {
                throw new Exception("Запрещенно вводить отрицательные числа");
            }

            int nod = 0;

            if (A != 0 && B != 0)
            {
                if (A > B)
                {
                    for (int i = 1; i <= B; i++)
                    {
                        if (A % i == 0 && B % i == 0)
                            nod = i;


                    }
                    return nod;
                }
                else
                {
                    for (int i = 1; i <= A; i++)
                    {
                        if (A % i == 0 && B % i == 0)
                            nod = i;
                    }
                    return nod;
                }
            
            }
            else
            {
                return A + B;
            }
        }
        public static bool IsPrime(int number)
        {
            bool temp = true;

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    temp = false;

                }


            }
            return temp;

        }
        public static int LCM(int A, int B)
        {
            if (A == 0 || B == 0)
            {
                throw new Exception("Числа не могут быть равны нулю");
            }
            if (A < 0 || B < 0)
            {
                throw new Exception("Запрещенно вводить отрицательные числа");
            }

            return Math.Abs(A * B) / GCD(A, B);
        }
    }
    
}
