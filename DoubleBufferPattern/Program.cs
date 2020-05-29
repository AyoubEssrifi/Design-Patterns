using System;

namespace DoubleBufferPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating scene
            Scene scene1 = new Scene();

            // Creating Actors
            Actor harry = new Actor("harry");
            Actor ron = new Actor("ron");
            Actor hermiony = new Actor("hermiony");

            // Adding actors to scene : take 1
            scene1.Add(harry);
            scene1.Add(ron);
            scene1.Add(hermiony);

            // Adding actors to scene : take 2
            //scene1.Add(hermiony);
            //scene1.Add(ron);
            //scene1.Add(harry);

            // Matchups
            harry.Face(ron);
            ron.Face(hermiony);
            hermiony.Face(harry);

            // Slap harry
            harry.Slap();

            // Update scene
            scene1.Update();
        }
    }
}
