using System;
using Discord;
using Discord.WebSocket;
using System.Threading.Tasks;

namespace DiscordBot
{
    public class Program
    {
        static void Main(string[] args)
        => new Program().StartAsync().GetAwaiter().GetResult();
        
        private DiscordSocketClient _client;

        public async Task StartAsync()
        {
            _client = new DiscordSocketClient();

            await _client.LoginAsync(TokenType.Bot, "NjY4NzQ1MDk2NzY1NzY3Njgx.XiWEag.5QswZGPHXcaYDDrQLj6BNr2_etM");

            await _client.StartAsync();

            await Task.Delay(-1);
        }
    }
}
