using System;

namespace class1_BE
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = new int[] { 4, 6, 7, 2 };
            //// Console.WriteLine(nums); // print the type name
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}
            //int[] nums2 = new int[4];
            //for (int i = 0; i < nums2.Length; i++)
            //{
            //    nums2[i] = int.Parse(Console.ReadLine());
            //}



            // Create a new array from the original one, where the new values are square vals of the original. 
            //int[] org = new int[] { 1, 2, 3, 4, 5 };
            //int[] copy = new int[5]; // expected values - {1, 4, 9, 16, 25}
            //for (int i=0; i<org.Length; i++)
            //{
            //    copy[i] = org[i] * org[i];
            //}
            //for (int i = 0; i < copy.Length; i++)
            //{
            //    Console.WriteLine(copy[i]);
            //}



            // Create a new array from an original one, where the new values are root squares vals of the original
            //int[] org = new int[] { 1, 16, 25, 30 };            
            //double[] copy = new double[4]; // { 1, 4, 5, 5.47234 }
            //// Math.Sqrt(5); // Returns the sqroot of any number // Can't use float as it won't be accurate - need to pick double in this situation. 

            //for (int i=0; i < org.Length; i++)
            //{
            //    copy[i] = Math.Sqrt(org[i]);  
            //}
            //for (int i = 0; i < copy.Length; i++)
            //{
            //    Console.WriteLine(copy[i]);
            //}



            // Create a new array from the original one,
            // where the new values are absolute vals of the original. 
            // absolute value: 5 and -5 is also 5

            //int[] org = new int[] { 1, 16, -25, -30 };
            //int[] copy = new int[4]; // { 1, 4, 5, 5.47234 }
            //// Math.Sqrt(5); // Returns the sqroot of any number // Can't use float as it won't be accurate - need to pick double in this situation. 

            //for (int i = 0; i < org.Length; i++)
            //{
            //    copy[i] = Math.Abs(org[i]);
            //}
            //for (int i = 0; i < copy.Length; i++)
            //{
            //    Console.WriteLine(copy[i]);
            //}

            // Create a new array from the original one,
            // where the new values are absolute vals of the original. 

            //Find the largest number in an array
            //int[] arr = new int[] { 13, 6, 7, 12, 99, 0 };
            //int result = int.MinValue;
            //for(int i=0; i < arr.Length; i++)
            //{
            //    if(arr[i] > result)
            //    {
            //        result = arr[i];
            //    }
            //}
            //Console.WriteLine(result);

            // Find the frequency of a number in an array.
            int[] arr = new int[] { 13, 6, 7, 12, 99, 0, 6, 7, 6 };
            int count = 0;
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == number)
                {
                    count++;
                }
                // If it was a sorted arr -> { 1, 2, 3, 4, 5, 99, 100, 200 }
                // if (arr[i] > number)                
                //    break;              
            }
            Console.WriteLine("The frequency of {0} is {1}", number, count);




            //Learning Console.WriteLine and basic if/else statement
            //Console.WriteLine("Welcome to my game...");
            //Console.WriteLine("Please Enter your age and OS type:");
            //int age = int.Parse(Console.ReadLine());
            //string OS = Console.ReadLine();
            //if (age >= 12 && OS == "Windows") 
            //{
            //    Console.WriteLine("You can start playing");
            //}
            //else
            //{
            //    Console.WriteLine("Please come back in " + (12 - age) + " years.");
            //}



            /*
            Will use these more
            string s = Console.ReadLine();
            int x = 0; // 4 bytes, byte = 8 // 32 bytes 
            int - Can't contain anything but an integer in an int - never accept a string (ex. 0.9 will not work)           
            int32 is the same size is int
            int64 can represent very high numbers.
            We will mostly use int
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            bool b = true; 0 - You only need 1 byte to represent a boolean
            char c = 'a'; 2 bytes 

            Differences and Comments
            float f = 1.34564f; Need an f in the end of float - Can go up to 7 digits - used to measure things, ex distance.
            double d = 1.3; Can go up to 15/16 digits  - used to measure things, ex distance, double takes more space then float. 
            decimal de = 1.38798756454654m; need an m at the end of a decimal - Can take up to  28/29 digits - used mainly banks 
            Using float and double are a lot faster then decimal as decimal takes up more memory. 
            */
        }

        // Writing Functions
        void 

    }
}
