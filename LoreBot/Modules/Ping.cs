using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoreBot.Modules
{
    [Group("ping")]
    public class Ping : ModuleBase<SocketCommandContext>
    {
        [Command]
        public async Task DefaultPingAsync()
        {
            await ReplyAsync("Pong!");
        }

        [Command("user")]
        public async Task PingUserAsync(SocketGuildUser user)
        {
            await ReplyAsync($"Pong! {user.Mention}");
        }
    }
}
