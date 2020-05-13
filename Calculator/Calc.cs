using System;

namespace AOUT.CH2.Calc
{
    public class Calculator
    {
        int temp = 0;
        public void Add(int number)
        {
            temp += number;
        }
         public int Sum()
        {
            int sum = temp;
            temp = 0;
            return sum;
        }
    }
}
