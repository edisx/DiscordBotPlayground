using DSharpPlus;
using DSharpPlus.CommandsNext;
using Microsoft.Extensions.Configuration;


//CommandsNextExtension Commands = null;

IConfigurationRoot config = new ConfigurationBuilder()
    .AddUserSecrets<Program>()
    .Build();

string discordToken = config["DiscordToken"];
string prefix = config["prefix"];

var discordConfig = new DiscordConfiguration()
{
    Intents = DiscordIntents.All,
    Token = discordToken,
    TokenType = TokenType.Bot,
    AutoReconnect = true,
};

DiscordClient Client = new DiscordClient(discordConfig);

Client.Ready += Client_Ready;

await Client.ConnectAsync();
await Task.Delay(-1);


Task Client_Ready(DiscordClient sender, DSharpPlus.EventArgs.ReadyEventArgs args)
{
    return Task.CompletedTask;
}