using System;

namespace seminar3
{
    class Program
    {

        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            if (num<=3)
            {
                Console.WriteLine("неудовлетворительно");
                return;
                
            }
            if (num<=5)
            {
                Console.WriteLine("удов-но");
                return;
            }
            if (num <= 7)
            {
                Console.WriteLine("хорошо");
                return;
            }
            else
            {
                Console.WriteLine("отлично");
                return;
            }
        }
    }
}
