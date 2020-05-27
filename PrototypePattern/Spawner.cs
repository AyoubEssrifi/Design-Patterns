using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    public class Spawner
    {
        private IMonster monster;
        public Spawner(IMonster monster)
        {
            this.monster = monster;
        }

        public void SpawnMonster()
        {
            monster.clone();
        }
    }
}
