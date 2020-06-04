using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class IdleState : IHeroState 
    {
        public void HandleInput(Hero hero, ConsoleKeyInfo keyInfo)
        {
            switch (keyInfo.Key)
            {
                case ConsoleKey.Spacebar:
                    hero.SetState(new JumpingState());
                    break;

                case ConsoleKey.C:
                    hero.SetState(new DuckingState());
                    break;

                default:
                    break;
            }
        }

        public void Update(Hero hero)
        {
            
        }
    }
}
