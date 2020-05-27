using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("Ayoub");

            ConsoleKeyInfo key = Console.ReadKey();

            if (key.Key == ConsoleKey.Spacebar)
            {
                JumpCommand jumpCommand = new JumpCommand(player);
                Invoker.AddCommand(jumpCommand);
            }

            Invoker.Update();
         
            
        }
    }
}
