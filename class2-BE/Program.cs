﻿using System;
using System.Dynamic;
using System.IO.Compression;
using System.Threading.Channels;

namespace class1_BE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select a number from 1 to 4");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1: 
                    // Process Complete numbers
                    Console.WriteLine("You chose Complete Number, please enter a number:");
                    int num = int.Parse(Console.ReadLine());
                    Console.WriteLine(IsComplete(num));
                    break;
                case 2:
                    // Process Complete in a range
                    Console.WriteLine("You chose Complete in a range, please enter two numbers:");
                    int startNum = int.Parse(Console.ReadLine());
                    int endNum = int.Parse(Console.ReadLine());
                    CompleteInRange(startNum, endNum);
                    break;
                case 3: 
                    // Process AreFriends
                    Console.WriteLine("You chose friend numbers, please enter two numbers:");
                    int num1 = int.Parse(Console.ReadLine());
                    int num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(AreFriends(num1, num2));
                    break;
                case 4:
                    // Process Friends in range
                    Console.WriteLine("You chose Friends in a specific range, please enter two numbers:");
                    int friendNum1 = int.Parse(Console.ReadLine());
                    int friendNum2 = int.Parse(Console.ReadLine());
                    RangeOfFriends(friendNum1, friendNum2);
                    break;
                default:
                    Console.WriteLine("Invalid, please choose between 1 and 4.");
                    break;
            }


        }


        // FUNCTIONS

        // Writing Functions
        // return type, name of function, and 
        // A function should do ONE thing. in general, if it is more the 15 - 20 - look at refactoring.
        static void PrintArray(int[] arrToPrint)
        {
            for (int i = 0; i < arrToPrint.Length; i++)
            {
                Console.WriteLine(arrToPrint[i]);
            }
        }


        // Write a function to return the frequency of a number in an integer array.
        static int NumFrequencyInArray(int[] arr, int number)
        {
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == number)
                {
                    result++;
                }
            }
            return result;
        }

        // Write a function to see if a number is complete
        // (the number is equal to the sum of it's divisors)
        // 6 : 3, 2, 1 : complete (sum is 6)
        // 12: 6, 4, 3, 2, 1 : not complete (sum is 16) 
        // 28: 14, 7, 4, 2, 1 : complete (sum is 28)
        static bool IsComplete(int num)
        {
            if (SumOfDivisors(num) == num)
                return true;
            return false;
        }

        // Write a function to print all complete numbers in range

        // writing a new function
        // Mixing functions
        static void CompleteInRange(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                if (IsComplete(i))
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Are all divisors of {0}", end);
        }

        // Making a new function.
        static void PrintCompleteNum(int num)
        {
            for (int i = 1; i < num / 2; i++)
            {
                if (num % i == 0)
                    Console.WriteLine("{0} is a divisor of {1}", i, num);
            }
        }

        // Friends numbers Function
        // X is a friend of Y if:
        // Sum of Divisors of X = Y and sum of Divisors of Y = X
        // example 1: 24, 36 : These are NOT friends
        // 24 -> 12, 8, 6, 4, 3, 2, 1 : 36
        // 36 -> 18, 12, 9, 6, 4, 3, 2, 1 : 55
        // example 2: 6, 6 : These ARE friends
        // example 3: 8, 8 : These are NOT friends
        // 1, 2, 4 : 7

        // Write a function to see if two numbers are friends
        static bool AreFriends(int x, int y)
        {
            int sumX = SumOfDivisors(x);
            if (sumX == y)
            {
                int sumY = SumOfDivisors(y);
                if (sumY == x)
                    return true;
            }
            return false;
        }


        static int SumOfDivisors(int num)
        {
            int result = 0;
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                    result += i;
            }
            return result;
        }

        // Get all friends numbers in a range
        static void RangeOfFriends(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                for (int j = i; j <= end; j++)
                { 
                    if (AreFriends(i, j))
                        Console.WriteLine("{0} and {1} are friends!", i, j);
                    ;
                }
            }
        }
    }
}
