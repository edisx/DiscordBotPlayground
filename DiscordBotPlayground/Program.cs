using DiscordBotPlayground.Commands;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using Microsoft.Extensions.Configuration;


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

var commandsConfig = new CommandsNextConfiguration()
{
    StringPrefixes = new string[] { prefix },
    EnableMentionPrefix = true,
    EnableDms = true,
    EnableDefaultHelp = true,
};

CommandsNextExtension Commands = Client.UseCommandsNext(commandsConfig);

Commands.RegisterCommands<TestCommands>();
await Client.ConnectAsync();
await Task.Delay(-1);


Task Client_Ready(DiscordClient sender, DSharpPlus.EventArgs.ReadyEventArgs args)
{
    Console.WriteLine(Client.CurrentUser.Username);
    return Task.CompletedTask;
}