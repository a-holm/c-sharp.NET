using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalsWhileExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 5;

            bool canDrive = age > 18 ? true : false;

            switch (age)
            {
                case 1:
                case 2:
                    Console.WriteLine("Go to kindergarden");
                    break;
                case 3:
                case 4:
                case 5:
                case 6:
                    Console.WriteLine($"Go to preschool");
                    break;
                default:
                    Console.WriteLine($"Go to another school");
                    break;
            }

            string name = "Derek";
            string name2 = "derek";

            if (name.Equals(name2, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"horse.");
            }

            int i = 1;
            while (i <= 10)
            {
                if (i % 2 == 0)
                {
                    i++;
                    continue;
                }
                if (i == 9) break;
                Console.WriteLine($"horse {i}.");
                i++;
            }

            double num1 = 5;
            double num2 = 0;

            try
            {
                Console.WriteLine($"horse do divisdion {DoDivision(5, 0)}.");
            }
            catch (DivideByZeroException ex)
            {

                Console.WriteLine($"hkhanke gjørre det.");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"hkhanke gjørre det.");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine($"cleaning up.");
            }
            

            Console.ReadLine();
        }

        static double DoDivision(double x, double y)
        {
            if (y == 0)
            {
                throw new System.DivideByZeroException();
            }
            return x / y;
        }

    }
}
