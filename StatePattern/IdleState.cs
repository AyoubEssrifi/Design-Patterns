using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class IdleState : IHeroState
    {
        private static float jumpingTime = 1000;
        private Timer jumpingTimer = new Timer(jumpingTime);
        public void HandleInput(Hero hero, string key)
        {
            switch (key)
            {
                case " ":
                    hero.SetState(new JumpingState());

                    // Return to idle state after 1 second
                    jumpingTimer.Start();

                    if (jumpingTimer.Finished)
                    {
                        hero.SetState(new IdleState());
                    }
                    break;

                case "c":
                    hero.SetState(new DuckingState());
                    break;

                default:
                    break;
            }
        }
    }
}
