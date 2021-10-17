using System;

namespace ConsoleApp112312312
{
    class Program
    {

        

        static void Main(string[] args)
        {
            
            string line = Console.ReadLine(); 
            int number = int.Parse(line);
            int count = 0;
            int max = 0;
            int min = 10;
            

            while (number>0)
            {
                count = number % 10;//123%10=3 3<10 min=3  3>0 => max=3 number =12 => 2<3 min=2 => 2>3 max=3 ; 1<min min=1; 1>max ;max=3 
                if (count < min)
                {
                    min = count;
                }
                if (count > max)
                {
                    max = count;
                    number = number / 10;
                }

            }
            Console.WriteLine(max);
            Console.WriteLine(min);
            
        }
    }
}
