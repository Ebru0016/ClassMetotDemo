using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    class ControlService : ILoggerService
    {
        public void log(Player player)
        {
            Console.WriteLine("Confirmed. " + player.FirstName);
        }
    }
}
