using System;

namespace E2
{
    class Program
    {
        static void Main()
        {
            do
            {
                int A, B, sum;
                A = Convert.ToInt32(Console.ReadLine());
                B = Convert.ToInt32(Console.ReadLine());
                sum = sumDif(A, B);
                Console.WriteLine(sum);
            }
            while (true);
        }
        static int sumDif(int A, int B)
        {
            int sum=0;
            A++;
            if (A < B)
            {
                sum += A;
                return sum + sumDif(A, B);
            }
            else return sum;
        }
    }
}
