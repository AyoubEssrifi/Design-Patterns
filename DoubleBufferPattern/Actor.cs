using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace DoubleBufferPattern
{
    public class Actor
    {
        private bool currentSlapped;
        private bool nextSlapped;
        private Actor facing;
        private string name;
        // Constructor
        public Actor(string name)
        {
            this.name = name;
            currentSlapped = false;
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
            nextSlapped = true;
        }
        public void Swap()
        {
            currentSlapped = nextSlapped;
            nextSlapped = false;
        }
        public bool WasSlapped()
        {
            return currentSlapped;
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
