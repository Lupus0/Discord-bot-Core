using DiscordBot_Core.Storage.implementations;
using DiscordBot_Core.Storage;
using System;
using DiscordBot_Core.Discord.Entities;
using DiscordBot_Core.Discord;

namespace DiscordBot_Core
{
    internal class Program
    {
        private static void Main()
        {
            Unity.RegisterTypes();
            Console.WriteLine("Hello, Discord!");

            var discordBotConfig = new BotConfig
            {
                Token = "ABC",
                SocketConfig = SocketConfig.GetDefault()
            };

            var connection = Unity.Resolve<Connection>();

        }
    }
}
