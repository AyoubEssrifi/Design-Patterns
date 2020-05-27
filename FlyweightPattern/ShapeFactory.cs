using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightPattern
{
    // Flyweight Factory
    public class ShapeFactory
    {
        private static Dictionary<string, IShape> shapeMap = new Dictionary<string, IShape>();

        public static IShape getShape(string shapeType)
        {
            IShape shape = null;
            if (shapeType.Equals("circle"))
            {
                if (shapeMap.TryGetValue(shapeType, out shape))
                {
     
                }
                else
                {
                    shape = new Circle();
                    shapeMap.Add("circle", shape);
                    Console.WriteLine("Creating shape circle");
                }
            }
            return shape;

        }
    }
}
