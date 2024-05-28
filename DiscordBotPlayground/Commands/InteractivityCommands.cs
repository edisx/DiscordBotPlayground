using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using DSharpPlus.Interactivity.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBotPlayground.Commands
{
    public class InteractivityCommands : BaseCommandModule
    {
        [Command("interact")]
        public async Task Interact(CommandContext ctx)
        {
            var interactivity = ctx.Client.GetInteractivity();

            while (true)
            {
                var messageToRetrieve = await interactivity.WaitForMessageAsync(message => message.Content == "hello");
                if (messageToRetrieve.Result.Content == "hello")
                {
                    await ctx.Channel.SendMessageAsync($"{ctx.User.Username} said hello");
                }
            }

        }

    }
}
