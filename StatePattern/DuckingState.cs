using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class DuckingState : IHeroState
    {
        public void HandleInput(Hero hero, string key)
        {
            if (key == " ")
            {
                hero.SetState(new JumpingState());
            }
        }
    }
}
