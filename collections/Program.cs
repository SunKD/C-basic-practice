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
            IcecreamFlavors();

        }

        // static Array multiD(int rows, int cols, int items){
        //     int [,,] array3d = new int [10, 1, 10];
        //     for(int i = 0; i < rows; i++){
        //         for (int j = 0; j < items; j++){
        //             array3d[i][j] = 
        //         }
        //     }
        // }

        static void IcecreamFlavors()
        {
            string[] IcecreamFlavors = { "Mint Chocolate", "Pudge double Chocolate", "Strawberry Banana", "Earl Grey", "Coffee", "Caramel Sea salt", "Green Tea", "Red bean", "Vanila Beans" };
            List<string> icecream = new List<string>(IcecreamFlavors.Length);
            for (var i = 0; i < IcecreamFlavors.Length; i++)
            {
                icecream.Add(IcecreamFlavors[i]);
            }
            System.Console.WriteLine("The length of Icecream Flavors array: " + icecream.Count);
            System.Console.WriteLine("The third flavor: " + icecream[2]);
            icecream.Remove(icecream[2]);
            System.Console.WriteLine("The length of Icecream Flavors array: " + icecream.Count);
        }
    }
}
