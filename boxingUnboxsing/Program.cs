using System;
using System.Collections.Generic;

namespace boxingUnboxsing
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = new List<object>{7, 28, -1, true, "chair"};
            int sum = 0;

            foreach(var item in items){
                if(item is int){
                    sum += (int)item;
                }
            }
            System.Console.WriteLine(sum);
        }
    }
}
