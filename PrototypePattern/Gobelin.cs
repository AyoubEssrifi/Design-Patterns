using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    public class Gobelin : IMonster
    {
        private float health;
        private float speed;
        public float Health { get; set; }
        public float Speed { get; set; }

        public Gobelin(float health, float speed)
        {
            this.health = health;
            this.speed = speed;
            Console.WriteLine("Creating Gobeling with: " + health + ": HP and " + speed + " speed");
        }

        public IMonster clone()
        {
            Console.WriteLine("Cloning Gobeling with: " + health + ": HP and " + speed + " speed");
            return new Gobelin(health, speed);
        }
    }
}
