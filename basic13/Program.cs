using System;
using System.Collections.Generic;

namespace basic13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic 13");
            // PrintToNum(255);
            // PrintOdd(255);
            // PrintNumSum(255);
            int [] arr = {3,5,6,9,10};
            // PrintArr(arr);
            // System.Console.WriteLine(FindMax(arr));
            // CreateOddArr(255);
            // GreaterThanY(arr, 6);
            // SquareValues(arr);
            int [] arr2 = {3,5,-6,9,-10};
            // EliminateNeg(arr2);
            MinMaxAve(arr2);
            object [] arr3 = {3,5,-6,9,-10};
            NumtoStr(arr3);
        }

        public static void PrintToNum(int num){
            for(int i = 1; i <= num; i++){
                System.Console.WriteLine(i);
            }
        }

        public static void PrintOdd(int num){
            for(int i = 1; i <= num; i +=2){
                System.Console.WriteLine(i);
            }
        }

        public static void PrintNumSum(int num){
            int sum = 0;
            for(int i = 1; i <= num; i++){
                sum += i;
                System.Console.WriteLine("New Number: " + i + " Sum: " + sum);
            }
        }

        public static void PrintArr(int [] nums){
            for(int i = 0; i < nums.Length; i++){
                System.Console.WriteLine(nums[i]);
            }
        }

        public static int FindSum(int [] nums){
            int sum = 0;
            for(int i = 1; i < nums.Length; i++){
                sum += nums[i];
            }
            return sum;
        }

        
        public static int FindMax(int [] nums){
            int max = nums[0];
            for(int i = 1; i < nums.Length; i++){
                if(nums[i] > max){
                    max = nums[i];
                }
            }
            return max;
        }

        public static int Average(int [] nums){
            int sum = FindSum(nums);
            return sum / nums.Length;
        }

        public static List<int> CreateOddArr(int num){
            List<int> oddList = new List<int>();
            for(int i = 1; i <= num; i+=2){
                oddList.Add(i);
                System.Console.WriteLine();
            }
            return oddList;
        }   

        public static int GreaterThanY(int [] arr, int y){
            int count = 0;
            for(int i = 0; i < arr.Length; i++){
                if(arr[i] > y){
                    count++;
                }
            }
            return count;
        }

        public static void SquareValues(int [] arr){
            for(int i = 0; i < arr.Length; i++){
                arr[i] = arr[i] * arr[i];
                System.Console.WriteLine(arr[i]);
            }
        }

        public static void EliminateNeg(int [] arr){
            for(int i = 0; i < arr.Length; i++){
                if(arr[i] < 0){
                    arr[i] = 0;
                }
                System.Console.WriteLine(arr[i]);
            }
        }

        public static void MinMaxAve(int [] arr){
            int min = arr[0]; 
            int max = arr[0];
            int sum = 0;
            for(int i = 1; i < arr.Length; i++){
                if(arr[i] < min){ 
                    min = arr[i];
                }
                if(arr[i] > max){
                    max = arr[i];
                }
                sum += arr[i];
            }
            System.Console.WriteLine("Mininum: " + min + " Maximum: " + max + " Average: " + sum/arr.Length);
        }

        public static int [] ShiftValues(int [] arr){
            arr[arr.Length-1] = 0;
            for(int i = 0; i < arr.Length-1; i++){
                arr[i] = arr[i+1];
            }
            return arr;
        }

        public static void NumtoStr(object [] arr){
            for(int i = 0; i < arr.Length; i++){
                if((int)arr[i] < 0){
                    arr[i] = "Dojo";
                }
                System.Console.WriteLine(arr[i]);
            }
        }
    }
}
