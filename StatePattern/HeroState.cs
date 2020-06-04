using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public interface IHeroState
    {
        void HandleInput(Hero hero, ConsoleKeyInfo keyInfo);

        void Update(Hero hero);

    }
}
