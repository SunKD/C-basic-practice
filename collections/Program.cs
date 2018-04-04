using System;
using System.Collections.Generic;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Collection Practice");
            int[] basicArr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            string[] nameArr = { "Tim", "Martin", "Nikki", "Sara" };
            string[] IcecreamFlavors = { "Mint Chocolate", "Fudge double Chocolate", "Strawberry Banana", "Earl Grey", "Coffee", "Caramel Sea salt", "Green Tea", "Red bean", "Vanila Beans" };
            customerFlavors(nameArr, IcecreamFlavors);

            multiD();
        }

        static void trueFalse()
        {
            bool[] boolArr = new bool[10];
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 != 0)
                {
                    boolArr[i] = false;
                }
                else
                {
                    boolArr[i] = true;
                }
            }
            foreach (var i in boolArr)
            {
                System.Console.WriteLine(i);
            }
        }

        static void multiD()
        {
            int[,] array2d = new int[10, 10];
            int count = 0;

            for (int j = 0; j < 10; j++)
            {
                Console.Write("[ ");
                count++;
                for (int i = 0; i < 10; i++)
                {
                    array2d[i, j] = count * (i + 1);
                    Console.Write(count * (i + 1) + ", ");
                }
                Console.Write("] ");
                System.Console.WriteLine();
            }
        }
        static void IcecreamFlavors(string[] arr)
        {
            List<string> icecream = new List<string>(arr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                icecream.Add(arr[i]);
            }
            System.Console.WriteLine("The length of Icecream Flavors array: " + icecream.Count);
            System.Console.WriteLine("The third flavor: " + icecream[2]);
            icecream.Remove(icecream[2]);
            System.Console.WriteLine("The length of Icecream Flavors array: " + icecream.Count);
        }

        static void customerFlavors(string[] customers, string[] flavors)
        {
            Random rand = new Random();
            Dictionary<string, string> customersFlavors = new Dictionary<string, string>(customers.Length);
            for (int i = 0; i < customers.Length; i++)
            {
                customersFlavors.Add(customers[i], null);
            }
            
            for (int i = 0; i < customers.Length; i++)
            {
                int flavorIndex = rand.Next(0, flavors.Length);
                customersFlavors[customers[i]] = flavors[flavorIndex];
            }
            
            foreach(KeyValuePair<string, string> customer in customersFlavors){
                System.Console.WriteLine(customer.Key + " - " + customer.Value);
            }
            
        }
    }
}
