using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class IdleState : IHeroState
    {
        public void HandleInput(Hero hero, string key)
        {
            switch (key)
            {
                case " ":
                    hero.SetState(new JumpingState());
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
