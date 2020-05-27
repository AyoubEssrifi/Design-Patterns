using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using System.Text;

namespace FlyweightPattern
{
    // Concerete Flyweight
    public class Circle : IShape
    {
        float xpos;
        float ypos;
        float radius;

        public string Color { get; set; }

        public void SetColor(string color)
        {
            this.Color = color;
        }

        public void Draw()
        {
            Console.WriteLine(" Circle: Draw() [Color : " + Color + ", X Cor : " + xpos + ", YCor :" + ypos + ", Radius :" + radius);
        }

    }
}
