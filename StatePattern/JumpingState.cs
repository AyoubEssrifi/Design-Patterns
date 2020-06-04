using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Timers;

namespace StatePattern
{
    public class JumpingState : IHeroState
    {
        Timer jumpingTimer;
        public JumpingState()
        {
            float jumpingTime = 2;
            jumpingTimer = new Timer(jumpingTime);

            jumpingTimer.Start();
        }
        public void HandleInput(Hero hero, ConsoleKeyInfo keyInfo)
        {
            
        }

        public void Update(Hero hero)
        {
            if (jumpingTimer.Finished)
            {
                hero.SetState(new IdleState());
            }
        }
    }
}
