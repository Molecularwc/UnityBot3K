﻿using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;
using UnityBot_3000.Discord.Entities;

namespace UnityBot_3000.Discord
{
    public class Connection
    {
        private readonly DiscordSocketClient _client;
        private readonly DiscordLogger _logger;

        public Connection(DiscordLogger logger, DiscordSocketClient client)
        {
            _logger = logger;
            _client = client;
        }

        internal async Task ConnectAsync(UnityBotConfig config)
        {
            _client.Log += _logger.Log;

            //TODO: Continue
        }
    }
}
