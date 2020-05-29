using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DoubleBufferPattern
{
    public class Scene
    {
        List<Actor> actorList = new List<Actor>();

        public void Add(Actor actor)
        {
            actorList.Add(actor);
        }
        
        public void Update()
        {
            for (int i = 0; i < actorList.Count; i++)
            {
                Console.WriteLine("Updating actor " + i + ": " + actorList[i].Name);
                actorList[i].Update();
            }

            Console.WriteLine("Update finished");

            for (int i = 0; i < actorList.Count; i++)
            {
                actorList[i].Swap();
            }
        }
    }
}
