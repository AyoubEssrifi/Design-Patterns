using System;
using System.Threading;
using System.Windows.Input;

namespace StatePattern
{
    class Program
    {
        private static ConsoleKeyInfo key;
        private static Thread t;
        static void Main(string[] args)
        {
            t = new Thread(new ThreadStart(GameLoop));
            t.Start();
            key = Console.ReadKey(true);

        }

        private static void GameLoop()
        {
            while (true)
            {
                Hero hero1 = new Hero("Ayoub");
                
                if (Keyboard.IsKeyDown(Key.Space))
                {
                    hero1.HandleInput(key);
                }
            }
        }
    }
}
