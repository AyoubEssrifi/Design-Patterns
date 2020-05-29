using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class IdleState : IdleStateable, IHeroState 
    {
        public void HandleInput(Hero hero, string key)
        {
            switch (key)
            {
                case " ":
                    hero.SetState(new JumpingState());
                    BackToIdleState(hero);
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
