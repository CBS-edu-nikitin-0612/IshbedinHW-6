using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int i, countWay = 1, countClient;

                List<int> clients = new List<int>();
                countClient = Convert.ToInt32(Console.ReadLine());
                i = countClient;
                do
                {
                    countWay *= i;
                    clients.Add(i);

                    i--;
                }
                while (i > 0);
                Console.WriteLine($"Количество маршрутов: {countWay}");


            }
            while (true);
        }

    }
}
