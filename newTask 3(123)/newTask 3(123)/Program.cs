using System;

namespace newTask_3_123_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(addedProsses(number));
        }
        public static  int addedProsses(int num)
        {
            int tempNumber = num;
            int tempValue = 3;
            while (num > 0)
            {
                int rem = num % 10;
                tempValue *= 10;
                num /= 10;

            }
            return tempNumber + tempValue;
        }
    }
}
