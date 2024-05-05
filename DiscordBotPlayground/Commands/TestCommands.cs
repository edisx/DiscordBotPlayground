using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBotPlayground.Commands
{
    public class TestCommands : BaseCommandModule
    {
        [Command("hello")]
        public async Task Hello(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("У, я, hello, мир");
        }

        [Command("add")]
        public async Task Add(CommandContext ctx, int number1, int number2)
        {
            int result = number1 + number2;
            await ctx.Channel.SendMessageAsync(result.ToString());
        }
    }
}
