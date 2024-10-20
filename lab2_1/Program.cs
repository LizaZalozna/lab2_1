using System;
namespace lab2_1
{
    class Program
    {
        static void Main()
        {
            MyMatrix m1 = new MyMatrix(new double[4, 2] { { 2, 4 }, { 2, 5 }, { 7, 3 }, { 8, 1 } });
            Console.WriteLine(m1);
            MyMatrix m2 = new MyMatrix(m1);
            Console.WriteLine(m2);
            MyMatrix m3 = new MyMatrix("2 1 \n 3 \t 9");
            Console.WriteLine(m3);
            MyMatrix m4 = new MyMatrix(new string[4] {"3 1 4", "3 \t 3 7", "1 2 \t 6","5 \t 73 \t 235" });
            Console.WriteLine(m4);
            MyMatrix m5 = new MyMatrix(new double[3][] { new double[]{ 12, 5 }, new double[]{ 71, 53 }, new double[]{ 18, 21 } });
            Console.WriteLine(m5);
            Console.WriteLine(m1 + m2);
            Console.WriteLine(m2 * m3);
            m2.TransponeMe();
            Console.WriteLine(m2);
            Console.ReadKey();
        }
    }
}