using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PracticeProblems
{
    class NumberArrayCounter
    {
        public static void NumberMain()
        {
            Console.WriteLine("Welcome to the Array Number Counter. This program counts the number of positive or negative numbers in a series of numbers given.\n" +
                "Please enter a set of 5 numbers");
            int num0 = int.Parse(Console.ReadLine());
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());

            int[] nums = { num0, num1, num2, num3, num4 };

            // Console.WriteLine($"The elements that you have entered are {num0} {num1} {num2} {num3} {num4}");
            foreach (var items in nums)
            {
                Console.Write($"You have entered: {items }\n");
                //Console.Write(items.ToString() + "\t");

            }
            Console.WriteLine(test(nums));
            

             static string test(int[] nums)
            {
                var pos = nums.Where(n => n > 0);
                var neg = nums.Where(n => n < 0);

                return "\nNumber of positive numbers: " + pos.Count() + "\nNumber of negative numbers: " + neg.Count();
            }
        }

    }
}
