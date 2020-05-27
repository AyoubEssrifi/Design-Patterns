using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class Hero
    {
        private string name;
        private IHeroState state;

        public string Name { get; set; }

        public Hero(string name)
        {
            this.name = name;
            this.state = new IdleState(); 
            Console.WriteLine("Hero: " + this.name + " is created" + " and in state: " + this.state);

        }

        public void SetState(IHeroState state)
        {
            this.state = state;
            Console.WriteLine(name + " state has changed to: " + this.state );
        }

        public void HandleInput(string key)
        {
            state.HandleInput(this, key);
        }
    }
}
