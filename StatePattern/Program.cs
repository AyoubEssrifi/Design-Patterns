using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;

namespace StatePattern
{
    class Program
    {
        private static ConsoleKeyInfo keyInfo;
        private static Hero hero1;

        public delegate void PressDelegate(ConsoleKeyInfo keyInfo);
        public static event PressDelegate OnPress;
        static void Main(string[] args)
        {
            // Creating Hero
            hero1 = new Hero("Ayoub");
            
            // Subscribing to KeyboardInput Event
            OnPress += KeyboardInputHandler;

            // Game Loop
            //t = new Thread(new ThreadStart(processInput));
            //t.Start();

            while (true)
            {
                processInput();
                hero1.Update();
            }
        }
        private static void processInput()
        {
            if (Console.KeyAvailable)
            {
                keyInfo = Console.ReadKey(true);
                OnPress(keyInfo);
            }

        }
        private static void KeyboardInputHandler(ConsoleKeyInfo keyInfo)
        {
            hero1.HandleInput(keyInfo);
        }
    }
}
