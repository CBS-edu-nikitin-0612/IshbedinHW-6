using System;
namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 20, i, j;
            for (i = 0; i < a; i++)
            {
                for (j = 0; j < b; j++) Console.Write("*");
                Console.Write("\n");
                
            }
            Console.ReadLine();
        }
    }
}
