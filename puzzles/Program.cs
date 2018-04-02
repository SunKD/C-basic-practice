using System;
using System.Collections.Generic;

namespace puzzles
{
    class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // int [] newarr = RandomArr();
            // System.Console.WriteLine(MaxValArr(newarr));
            // System.Console.WriteLine(MinValArr(newarr));
            // System.Console.WriteLine(SumArr(newarr));
            // System.Console.WriteLine(TossCoin());
            // System.Console.WriteLine(TossMultipleCoins(10));
            string [] names = {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            // ShuffleArr(names);
            // PrintArr(names);
            // Longerthan5(names);
            PrintList(Longerthan5(names));
        }
        public static int [] RandomArr(){
            int [] arr = new int[10];
            for(int i = 0; i < 10; i++){
                int num = rand.Next(5, 26);
                arr[i] = num;
            }
            return arr;
        }

        public static int MaxValArr(int [] arr){
            int max = arr[0];
            for(int i = 1; i < arr.Length; i++){
                if(arr[i] > max){
                    max = arr[i];
                }
            }
            return max;
        }

        public static int MinValArr(int [] arr){
            int min = arr[0];
            for(int i = 1; i < arr.Length; i++){
                if(arr[i] < min){
                    min = arr[i];
                }
            }
            return min;
        }

        public static int SumArr(int [] arr){
            int sum = 0;
            for(int i = 0; i < arr.Length; i++){
                sum+= arr[i];
            }
            return sum;
        }

        //Toss coin 
        public static string TossCoin(){
            System.Console.WriteLine("Tossing a Coin!");
            int result = rand.Next(0, 2);
            if(result == 0){
                return "Head";
            }else{
                return "Tail";
            }
        }

        public static double TossMultipleCoins(int num){
            int heads = 0;
            int tails = 0;
            for(int i = 1; i < num; i++){
                string result = TossCoin();
                if(result == "Head"){
                    heads+= 1;
                }else{
                    tails += 1;
                }
            }
            System.Console.WriteLine("Heads: " + heads + ", Tails: " + tails);
            return (double)heads/num;
        }

        public static void ShuffleArr(string [] arr){
            int index = 0;
            for(int i = 0; i < arr.Length; i++){
                string first = arr[i];
                int ranIndex = rand.Next(i, arr.Length);
                arr[i] = arr[ranIndex];
                arr[ranIndex] = first;
                index++;
            }
        }

        public static List<string> Longerthan5(string [] arr){
            List<string> longerThan5Chars = new List<string>();
            for(int i = 0; i < arr.Length; i++){
                if(arr[i].Length > 4){
                    longerThan5Chars.Add(arr[i]);
                }
            }
            return longerThan5Chars;
        }

        public static void PrintArr(string [] arr){
            for(int i = 0; i < arr.Length; i++){
                System.Console.WriteLine(arr[i]);
            }
        } 
        public static void PrintList(List<string> arr){
            for(int i = 0; i < arr.Count; i++){
                System.Console.WriteLine(arr[i]);
            }
        }
    }
}
