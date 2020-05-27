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
            hero1 = new Hero("Ayoub");

            OnPress += KeyboardInputHandler;

            t = new Thread(new ThreadStart(KeyboardInput));
            t.Start();

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
