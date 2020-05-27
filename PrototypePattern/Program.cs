using System;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IMonster goblinPrototype = new Gobelin(10, 20);
            Spawner goblinSpawner = new Spawner(goblinPrototype);
            goblinSpawner.SpawnMonster();
        }
    }
}
