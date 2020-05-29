using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace DoubleBufferPattern
{
    public class Actor
    {
        private bool slapped;
        private Actor facing;
        private string name;
        // Constructor
        public Actor(string name)
        {
            this.name = name;
            slapped = false;
        }
        // Properties
        public string Name
        {
            get
            {
                return name;
            }
        }
        public void Face(Actor actor)
        {
            facing = actor;
        }
        public void Slap()
        {
            Console.WriteLine(name + " is slapped");
            slapped = true;
        }
        public void Reset()
        {
            slapped = false;
        }
        public bool WasSlapped()
        {
            return slapped;
        }
        public void Update()
        {
            if (WasSlapped())
            {
                facing.Slap();
            }
        }
    }
}
