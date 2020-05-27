using System;

namespace FlyweightPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Red circles");
            for (int i = 0; i < 3; i++)
            {
                Circle circle = (Circle)ShapeFactory.getShape("circle"); // returns IShape not Circle, thus the need to cast it
                circle.SetColor("Red");
                circle.Draw();
            }

            Console.WriteLine();

            Console.WriteLine("Green circles");
            for (int i = 0; i < 3; i++)
            {
                Circle circle = (Circle)ShapeFactory.getShape("circle"); // returns IShape not Circle, thus the need to cast it
                circle.SetColor("Green");
                circle.Draw();
            }
        }
    }
}
