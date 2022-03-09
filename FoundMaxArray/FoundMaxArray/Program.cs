using System;

namespace FoundMaxArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = { 2, 5, 6, 7, 11, 8, 9 };
            Console.WriteLine(findMax(Arr));
        }
        public static int findMax(int[] Arr)
        {
            int MaxNum = Arr[0];
            foreach (int numbers in Arr)
            {
                if (numbers > MaxNum)
                {
                    MaxNum = numbers;
                }
            }
            return MaxNum;
        }
    }
}
