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


                drawWays(in clients, countWay);
            }
            while (true);
        }
        static void drawWays(in List<int> clients, int countWay)
        {
            int i, j;
            DataTable dataTable = new DataTable();
            for (j = 0; j < clients.Count; j++)
            {
                dataTable.Columns.Add(new DataColumn(j.ToString(), Type.GetType("System.Int32")));
            }

            for (i = 0; i < countWay; i++)
            {
                dataTable.Rows.Add(dataTable.NewRow());
            }

            j = 0;
            foreach (int client in clients)
            {
                i = 0;
                for (i = i; i < dataTable.Rows.Count; i++)

                {
                    dataTable.Rows[i][j] = client;
                    j++;
                    if (j == clients.Count) j -= clients.Count;
                }
                j++;
            }

            for (i = 0; i < countWay; i++)
            {
                for (j = 0; j < clients.Count; j++)
                {
                    Console.Write(dataTable.Rows[i][j]);
                }
                Console.Write("\n");

            }


        }

    }
}
