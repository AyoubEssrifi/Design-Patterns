using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class JumpCommand : ICommand
    {
        Player player;

        public JumpCommand(Player player)
        {
            this.player = player;
        }
        public void Execute()
        {
            player.Jump();
        }
    }
}
