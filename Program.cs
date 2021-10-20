using System;

namespace Lab_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());




            Console.WriteLine(Logic.Multiply(x, y));

        }
    }

    public class Logic
    {
        public static int Multiply(int x, int y)
        {
            int b = 0;

            for (int i = 0; i < y; i++)
            {
                b = b + x;
            }
            return b;
        }
    }
}
