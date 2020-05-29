using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;

namespace StatePattern
{
    class Program
    {

        private static string key;
        private static Thread t;
        private static Hero hero1;

        public delegate void PressDelegate();
        public static event PressDelegate OnPress;
        static void Main(string[] args)
        {
            // Creating Hero
            hero1 = new Hero("Ayoub");
            
            // Subscribing to KeyboardInput Event
            OnPress += KeyboardInputHandler;

            // Game Loop
            t = new Thread(new ThreadStart(KeyboardInput));
            t.Start();

            //while (true)
            //{
            //    hero1.Update();
            //}
        }
        private static void KeyboardInput()
        {
            while (true)
            {
                key = Console.ReadLine();
                OnPress();
            }

        }
        private static void KeyboardInputHandler()
        {
            hero1.HandleInput(key);
        }
    }
}
