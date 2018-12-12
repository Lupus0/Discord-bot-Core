using DiscordBot_Core.Storage.implementations;
using DiscordBot_Core.Storage;
using System;
using DiscordBot_Core.Discord.Entities;
using DiscordBot_Core.Discord;
using System.Threading.Tasks;

namespace DiscordBot_Core
{
    internal class Program
    {
        private static async Task Main()
        {
            Unity.RegisterTypes();
            Console.WriteLine("Hello, Discord!");

            var storage = Unity.Resolve<IDataStorage>();

            var connection = Unity.Resolve<Connection>();
            await connection.ConnectAsync(new BotConfig
            {
                Token = storage.RestoreObject<string>("Config/BotToken")
            });

        }
    }
}
