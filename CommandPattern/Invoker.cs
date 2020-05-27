using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public static class Invoker
    {
        static Queue<ICommand> commandBuffer = new Queue<ICommand>();

        public static void AddCommand(ICommand command)
        {
            commandBuffer.Enqueue(command);
        }

        public static void Update()
        {
            while (true)
            {
                //if (commandBuffer == null) commandBuffer;

                if (commandBuffer.Count > 0)
                {
                    for (int i = 0; i < commandBuffer.Count; i++)
                    {
                        ICommand c = commandBuffer.Dequeue();
                        c.Execute();
                    }
                }
                
            }
        }

    }
}
