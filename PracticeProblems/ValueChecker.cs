using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProblems
{
    class ValueChecker
    {
        public static void MainValue()
        {
            string temp;
            char input;

            {
                Console.WriteLine("Enter in a number, letter or symbol that you want to check the ASCII Value off.");
                temp = Console.ReadLine();
                input = char.Parse(temp);
                Console.WriteLine($"The value of {temp} is {test(input)}");
                Repeat();
            }
        }

        public static int test(char temp)
        {
            return (int)temp;
        }

        public static void Repeat()
        {
            string inputTemp;
            char inputValue;
            Console.WriteLine($"Would you like to check another value?");
            Console.WriteLine($"Y for yes || N for no");
            if(Console.ReadKey().Key == ConsoleKey.Y)
            {
                MainValue();
            }

            
        }
    }
}
