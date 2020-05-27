using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace StatePattern
{
    public class JumpingState : IHeroState
    {
        private float jumpingTime = 1000;
        private float elapsedTime;
        public void HandleInput(Hero hero, ConsoleKeyInfo key)
        {
            if (elapsedTime >= jumpingTime)
            {
                hero.SetState(new IdleState());
            }
            else
            {
                elapsedTime += 1;
            }
            Console.WriteLine(elapsedTime);
        }
    }
}
