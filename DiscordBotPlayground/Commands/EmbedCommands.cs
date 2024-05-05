using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBotPlayground.Commands
{
    public class EmbedCommands : BaseCommandModule
    {
        [Command("embed")]
        public async Task Embed(CommandContext ctx)
        {
            var message = new DiscordMessageBuilder()
                .AddEmbed(new DiscordEmbedBuilder()
                .WithTitle("amogus")
                .WithDescription("sus")
                .WithColor(DiscordColor.Orange)
                );

            await ctx.Channel.SendMessageAsync(message);
        }

        [Command("embed2")]
        public async Task Embed2(CommandContext ctx)
        {
            var message = new DiscordEmbedBuilder()
            {
                Title = "amogus",
                Description = "sus",
                Color = DiscordColor.Purple,
            };

            await ctx.Channel.SendMessageAsync(embed: message);
        }
    }
}
