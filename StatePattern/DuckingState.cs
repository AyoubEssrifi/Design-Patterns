using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class DuckingState : IHeroState
    {
        public void HandleInput(Hero hero, ConsoleKeyInfo keyInfo)
        {
            switch (keyInfo.Key)
            {
                case ConsoleKey.Spacebar:
                    hero.SetState(new JumpingState());
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
