using System;
using System.Collections.Generic;

namespace Basic13
{
    class Program
    {
        // Print 1-255
        public static void PrintNumbers(){
            for(int i = 1; i <= 255; i++){
                Console.WriteLine(i);
            }
        }

        // Print odd numbers between 1-255
        public static void PrintOdds(){
            for(int i = 1; i <= 255; i++){
                if(i % 2 != 0){
                    Console.WriteLine(i);
                }
            }
        }

        // Print Sum
        public static void PrintSum(){
            int sum = 0;
            for(int i = 0; i <= 255; i++){
                Console.WriteLine(i);
                Console.WriteLine(sum += i);
            }
        }

        // Iterating through an Array
        public static void LoopArray(int[] numbers){
            for(int i = 0; i < numbers.Length; i++){
                Console.WriteLine(numbers[i]);
            }
        }

        // Find Max
        public static void FindMax(int[] numbers){
            int max = numbers[0];
            for(int i = 0; i < numbers.Length; i++){
                if(numbers[i] > max){
                    max = numbers[i];
                }
            }
            Console.WriteLine(max);
        }

        // Get Average
        public static void GetAverage(int[] numbers){
            int sum = 0;
            for(int i = 0; i < numbers.Length; i++){
                sum += numbers[i];
            }
            Console.WriteLine(sum/numbers.Length);
        }

        // Array with Odd Numbers
        public static void OddArray(){
            var newArr = new List<int>();
            for(int i = 1; i <= 255; i++){
                if(i % 2 != 0){
                newArr.Add(i);
                }
            }
            Console.WriteLine(newArr);
        }

        // Greater than Y
        public static int GreaterThanY(int[] numbers, int y){
            int count = 0;
            for(int i = 0; i < numbers.Length; i++){
                if(numbers[i] > y){
                    count++;
                }
            }
            return count;
        }

        // Square the Values
        public static void SquareArrayValues(int[] numbers){
            for(int i = 0; i < numbers.Length; i++){
                numbers[i] = i * i; 
            }
            Console.WriteLine(numbers);
        }

        // Eliminate Negative Numbers
        public static void EliminateNegatives(int[] numbers){
            for(int i = 0; i < numbers.Length; i++){
                if(numbers[i] < 0){
                    numbers[i] = 0;
                }
            }
            Console.WriteLine(numbers);
        }

        // Min, Max, and Average
        public static void MinMaxAverage(int[] numbers){
            int max = numbers[0];
            int min = numbers[0];
            int sum = 0;
            for(int i = 0; i < numbers.Length; i++){
                if(numbers[i] > max){
                    max = numbers[i];
                }
                if(numbers[i] < min){
                    min = numbers[i];
                }
                sum += numbers[i];
            }
            Console.WriteLine("Max number is " + max);
            Console.WriteLine("Min number is " + min);
            Console.WriteLine("Average value in array is " + sum/numbers.Length);
        }

        // Shifting the values in an array
        public static void ShiftValues(int[] numbers){
            for(int i = 1; i < numbers.Length; i++){
                numbers[i - 1] = numbers[i];
            }
            numbers[numbers.Length - 1] = 0;
            Console.WriteLine(numbers);
        }

        // Number to string
        public static void NumToString(List<object> numbers){
            for(int i = 0; i < numbers.Length; i++){
                if(numbers[i] < 0){
                    numbers[i] = "Dojo";
                }
            }
            Console.WriteLine(numbers);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // PrintNumbers();
            // PrintOdds();
            // PrintSum();
            // int[] arr = {1,2,3,4,5};
            // LoopArray(arr);
            // FindMax(arr);
            // GetAverage(arr);
            // OddArray();
            // int[] arr = {1, 3, 5, 7};
            // int y = 3;
            // Console.WriteLine(GreaterThanY(arr, y));
            // int[] arr = {1,5,10,-10};
            // SquareArrayValues(arr);
            // int[] numbers = {1, 5, 10, -2};
            // EliminateNegatives(numbers);
            // int[] numbers = {1,5,10,-2};
            // MinMaxAverage(numbers);
            // int[] numbers = {1,5,10,7,-2};
            // ShiftValues(numbers);
            // int[] numbers = {-1,-3,2};
            // Console.WriteLine(NumToString(numbers));
        }
    }
}
