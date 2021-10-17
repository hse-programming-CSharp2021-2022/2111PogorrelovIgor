using System;

namespace seminar2
{
    class Program
    {
        static void Main(string[] args)
        {
            string op;
            double result = 0;
            Console.WriteLine("Введите a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Что делать с выражением: -,+,/,*");
            op = Console.ReadLine();
            switch (op)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "/":
                    result = a / b;
                    break;
                case "*":
                    result = a * b;
                    break;
            }
            Console.WriteLine("Ответ:{0}", result);
            Console.ReadKey();
        }
    }
}
