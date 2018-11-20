using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiscordBot_Core.Discord.Entities
{
    public class BotConfig
    {
        public string Token { get; set; }
        public DiscordSocketConfig SocketConfig { get; set; }
    }
}
