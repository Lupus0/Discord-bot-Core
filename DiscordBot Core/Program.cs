using DiscordBot_Core.Storage.implementations;
using DiscordBot_Core.Storage;
using System;
using Discord.WebSocket;
using System.Threading.Tasks;

namespace DiscordBot_Core
{
    internal class Program
    {
        private static void Main()
        {
            Unity.RegisterTypes();
            Console.WriteLine("Hello, Discord!");
        }
    }
}
