using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyramidRecursiveMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een nummer");
            
            DrawPyramid(int.Parse(Console.ReadLine()));
        }
        static void DrawPyramid(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                for (int j = i; j <= num; j++)
                {
                    Console.Write("  ");
                }
                for (int k = 1; k <= 2 * i - 1; k++) // 2 * i - 1
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
