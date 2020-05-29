using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class IdleStateable
    {
        public void BackToIdleState(Hero hero)
        {
            float jumpingTime = 1000;
            Timer jumpingTimer = new Timer(jumpingTime);
            // Return to idle state after 1 second
            jumpingTimer.Start();

            if (jumpingTimer.Finished)
            {
                hero.SetState(new IdleState());
            }

        }
    }
}
