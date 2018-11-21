using System;

namespace DiscordBot_Core
{
    public class logger  : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
