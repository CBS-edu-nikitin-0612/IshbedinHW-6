using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3
{
    class Program
    {
        static void Main(string[] args)
        {

            DrawRectangle();
            Console.Write("\n");

            DrawRightTriangle();
            Console.Write("\n");

            DrawIsoscelesTriangle();
            Console.Write("\n");

            DrawRhombus();

            Console.ReadLine();
        }
        static void DrawRectangle()
        {
            int a = 20, b = 5, i, j;
            //рисуем верх
            for (i = 0; i < a; i++) Console.Write("#");
            Console.Write("\n");
            //рисуем стороны
            for (i = 0; i < b - 2; i++)
            {
                Console.Write("#");
                for (j = 0; j < a - 2; j++) Console.Write(" ");
                Console.Write("#");
                Console.Write("\n");
            }
            //Рисуем низ
            for (i = 0; i < a; i++) Console.Write("#");
            Console.Write("\n");

        }
        static void DrawRightTriangle()
        {
            int countRow = 20, countColumn = 31, row, column;

            //Рисуем вершину
            Console.Write("#");
            Console.Write("\n");

            //рисуем стороны
            for (row = 1; row < countRow; row++)
            {
                Console.Write("#");

                for (column = 1; column < (int)(countColumn * row / countRow); column++)
                {
                    Console.Write(" ");
                }
                Console.Write("#");
                Console.Write("\n");
            }
            //Рисуем низ
            for (row = 0; row < countColumn; row++) Console.Write("#");
            Console.Write("\n");

        }
        static void DrawIsoscelesTriangle()
        {
            int countRow = 10, countColumn = 31, row, column;

            //Рисуем вершину
            for (column = 0; column < countColumn / 2; column++) Console.Write(" ");
            Console.Write("#");
            Console.Write("\n");


            //рисуем стороны
            for (row = 1; row < countRow; row++)
            {
                for (column = 0; column < (countColumn / 2 - (countColumn * row / 2 / countRow)); column++) Console.Write(" ");

                Console.Write("#");

                for (column = 0; column < (countColumn * row / countRow) - 1; column++)
                {
                    Console.Write(" ");
                }
                Console.Write("#");
                Console.Write("\n");
            }
            //Рисуем низ
            for (row = 0; row < countColumn; row++) Console.Write("#");
            Console.Write("\n");

        }
        static void DrawRhombus()
        {
            int a = 30, b = 10, x, y;

            for (y = 0; y < b*2+2; y++)
            {
                for (x = 0; x < a*2+2; x++)
                {
                    if ((Math.Abs((Double)y - (b+1)) / b + Math.Abs((Double)x - (a+1)) / a) <= 1) Console.Write("#");
                    else Console.Write(" ");
                }
                Console.Write("\n");
            }


        }

    }

}
