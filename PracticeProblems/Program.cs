using System;
using System.Threading.Tasks;
using static PracticeProblems.SnakeGame;
using static PracticeProblems.ValueChecker;
using static PracticeProblems.NumberArrayCounter;

namespace PracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Hello();
            Sum();
            Divide();*/
            // NumberSwap();
            //MainSnake();
            //MainValue();
            NumberMain();
        }

        static void Hello()
        {
            Console.WriteLine(" Hello \n Welcome to my Portfolio for .Net Developer");
            Console.WriteLine(" My name is James and I hope\n this impresses you enough to offer me a position");
        }

        public static void Sum()
        {
            Console.WriteLine("Welcome to the sum function");
            Console.WriteLine($"Please Enter a Number");
            int a;
            string aInput = Console.ReadLine();
            Console.WriteLine("Please enter a second number");
            int b;
            string bInput = Console.ReadLine();


            if (!int.TryParse(aInput, out a))
            {
                Console.WriteLine("Please enter a whole number!");
                aInput = Console.ReadLine();
            }

            if (!int.TryParse(bInput, out b))
            {
                Console.WriteLine("PLEASE enter a whole number!");
                bInput = Console.ReadLine();
            }
            int sum = a + b;

            Console.WriteLine($"The sum of your number is {sum}");
            Console.WriteLine("Thank you for you visit to the sum function");
        }

        public static void Divide()
        {
            Console.WriteLine($"Welcome to the Division function");
            Console.WriteLine($"What is the first number?");
            double a;
            string aInput = Console.ReadLine();
            Console.WriteLine($"What is the second number?");
            double b;
            string bInput = Console.ReadLine();

            if (!double.TryParse(aInput, out a) || (!double.TryParse(bInput, out b)))
            {
                Console.WriteLine($"Please enter a valid number");
                aInput = Console.ReadLine();
                bInput = Console.ReadLine();
            }
            else
            {
                double remainder = a / (double)b;
                Console.WriteLine($"The remainder of the two numbers is: {remainder}");
            }

            Console.WriteLine($"Thanks for visiting the division function");
        }

        static void NumberSwap()
        {
            var t = Task.Run(async delegate
            {
                await Task.Delay(TimeSpan.FromSeconds(2.0));
                return 42;
            });
            int number1, number2, temp;
            Console.WriteLine($"Input the first number");
            t.Wait((int)1.0);
            number1 = int.Parse(Console.ReadLine());
            Console.Write($"\n{t.Result} \n_______________________\n");
            Console.WriteLine("Input your second number");
            t.Wait((int)5.0);
            
            number2 = int.Parse(Console.ReadLine());
            Console.Write($"\n{t.Result} \n_______________________\n");
            t.Wait((int)3.0);
            Console.Write($"\n{t.Result} \n_______________________\n");
            Console.WriteLine($"Before swapping \n number 1 = {number1} \n and number 2 = {number2}");
            temp = number1;
            number1 = number2;
            number2 = temp;           
            t.Wait();
            Console.Write($"\n{t.Result} \n_______________________\n");
            Console.Write($"\n After swapping \n number 1 = {number1}\n and number 2 = {number2}");
            Console.Read();
            
            
        }
    }

}
