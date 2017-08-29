using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            double EX = 5;
            double IY = 4;
            Console.WriteLine($"5 + 4 = {GetSum(EX, IY)}");

            int solution;
            DoubleIt(15, out solution);

            Console.WriteLine($"15 * 2 = {solution}");

            int num1 = 10;
            int num2 = 20;

            Console.WriteLine($"Before: num1: {num1},  num2: {num2}");
            Swap(ref num1, ref num2);
            Console.WriteLine($"After: num1: {num1},  num2: {num2}");

            Console.WriteLine($"1 + 2 + 3 = {GetSumMore(1, 2, 3)}");

            PrintInfo(zipCode: 15147, name: "Derek");

            Console.WriteLine($"5.0 + 4.5 = {GetSum(5.0, 4.5)}");
            Console.WriteLine($"5 + 4 = {GetSum(5, 4)}");
            Console.WriteLine($"5 + 4 = {GetSum("5", "4")}");

            CarColor car1 = CarColor.Blue;
            PaintCar(car1);

            Console.ReadLine();
        }

        enum CarColor : byte
        {
            Orange = 1,
            Blue,
            Green,
            Red,
            Yellow
        }

        static void PaintCar(CarColor cc)
        {
            Console.WriteLine($"The car was painted {cc} with the code {(int)cc}");
        }

        static void PrintInfo(string name, int zipCode)
        {
            Console.WriteLine($"{name} lives in the zipcode {zipCode}");
        }

        static double GetSumMore(params double[] nums)
        {
            double sum = 0;
            foreach (var i in nums)
            {
                sum += i;
            }
            return sum;
        }

        public static void Swap(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;

        }

        static double GetSum(double x = 1, double y = 1)
        {
            return x + y;
        }

        static double GetSum(string x = "1", string y = "1")
        {
            double dblX = Convert.ToDouble(x);
            double dblY = Convert.ToDouble(y);
            return dblX + dblY;
        }

        static void DoubleIt(int x, out int solution)
        {
            solution = x * 2;
        }
    }
}
