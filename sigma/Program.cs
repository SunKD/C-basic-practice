using System;

namespace sigma
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(Sigma(5));
            object[] nums = { 1, 3, 5, -7, -8, 7 };
            // System.Console.WriteLine(MakeFalse(nums));
            MakeFalse(nums);
        }

        public static int Sigma(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num;
                num--;
            }
            return sum;
        }

        public static object[] MakeFalse(object[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if ((int)arr[i] < 0)
                {
                    arr[i] = false;
                }
                System.Console.WriteLine(arr[i]);

            }
            return arr;
        }
    }
}
