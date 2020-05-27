using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class Player
    {
        string name;
        public Player(string name)
        {
            this.name = name;
        }
        public void Jump()
        {
            Console.WriteLine(name + " is jumping !");
        }
    }
}
