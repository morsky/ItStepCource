using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter operqation type (+, -, *)");
            string opration = Console.ReadLine();

            MathOperations mp;

            switch (opration)
            {
                case "+":
                    mp = MathOperations.Addtion;
                    break;
                case "-":
                    mp = MathOperations.Substract;
                    break;
                case "*":
                    mp = MathOperations.Multiply;
                    break;
                default:
                    mp = MathOperations.Addtion;
                    break;
            }

            var del = CalcFactory.Create(mp);

            Console.WriteLine(del(firstNumber, secondNumber));
        }
    }
}