using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1;
            rect1.length = 200;
            rect1.width = 50;
            Console.WriteLine($"Area of rect1 : {rect1.Area()}");

            Rectangle rect2 = new Rectangle(100, 40);
            Console.WriteLine($"Area of rect2 : {rect2.Area()}");

            rect2 = rect1;
            rect1.length = 33;
            Console.WriteLine($"Length of rect2 : {rect2.length}");

            Animal fox = new Animal("Red", "Raaaw");

            Console.WriteLine($"# of Animals : {Animal.GetNumAnimals()} named {fox.name}");
            fox.MakeSound();

            Console.WriteLine("###############################################");
            Console.WriteLine($"Area of Rectangle : {ShapeMath.GetArea("rectangle", 5, 6)}");

            Console.ReadLine();
        }

        struct Rectangle
        {
            public double length;
            public double width;

            public Rectangle(double l = 1, double w = 1)
            {
                length = l;
                width = w;
            }

            public double Area()
            {
                return length * width;
            }
        }
    }
}
