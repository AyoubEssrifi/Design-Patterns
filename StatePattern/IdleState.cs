using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class IdleState : IHeroState
    {
        public void HandleInput(Hero hero, ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.Spacebar)
            {
                hero.SetState(new JumpingState());
            }
        }
    }
}
