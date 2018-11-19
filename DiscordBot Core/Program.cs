using DiscordBot_Core.Storage.implementations;
using DiscordBot_Core.Storage;
using System;

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

