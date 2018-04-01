using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using TwitchDiscordBot.Modules;

namespace TwitchDiscordBot
{
    internal class DiscordBot
    {
        private readonly DiscordSocketClient discord;
        private readonly CommandService commands = new CommandService();
        private IServiceProvider services = new ServiceCollection().BuildServiceProvider();
        DiscordCommandModule dModule = new DiscordCommandModule();

        internal DiscordBot()
        {
            discord = new DiscordSocketClient(new DiscordSocketConfig
            {
                // For logging purposes and messaging
                LogLevel = LogSeverity.Info,
                MessageCacheSize = 50
            });
        }

        private static Task Logger(LogMessage message)
        {
            var cc = Console.ForegroundColor;
            switch (message.Severity)
            {
                case LogSeverity.Critical:

                case LogSeverity.Error:

                    Console.ForegroundColor = ConsoleColor.Red;
                    break;

                case LogSeverity.Warning:

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;

                case LogSeverity.Info:

                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                case LogSeverity.Verbose:

                case LogSeverity.Debug:

                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
            }

            Console.WriteLine($"{DateTime.Now,-19} [{message.Severity,8}] {message.Source}: {message.Message}");
            Console.ForegroundColor = cc;

            // If you *need* to run on .NET 4.5 for compat/other reasons,
            // the alternative is to 'return Task.Delay(0);' instead.
            return Task.Delay(0);
        }

        internal async Task MainAsync()
        {
            // Subscribe the logging handler.
            discord.Log += Logger;

            // Centralize the logic for commands into a seperate method.
            await initCommands();

            // Login and connect.
            await discord.LoginAsync(TokenType.Bot, DiscordBotInfo.BotToken);
            await discord.StartAsync();

            discord.Ready += () =>
            {
                return Task.Delay(0);
            };

            // Wait infinitely so the bot actually stays connected.
            await Task.Delay(-1);
        }

        internal async Task initCommands()
        {
            discord.MessageReceived += HandleCommandAsync;

            // Discovers all of the commands in this assembly and load them.
            await commands.AddModulesAsync(Assembly.GetEntryAssembly());
        }

        private async Task HandleCommandAsync(SocketMessage arg)
        {
            // Bail out if it's a System Message.
            var msg = arg as SocketUserMessage;
            if (msg == null)
            {
                return;
            }

            // This is a position counter to know where would the command start
            int pos = 0;

            // Either you could address the bot with '!' or @[BotName]
            if (msg.HasCharPrefix('!', ref pos) || msg.HasMentionPrefix(discord.CurrentUser, ref pos))
            {
                // Create a Command Context.
                var context = new SocketCommandContext(discord, msg);

                // Execute the command. (result does not indicate a return value, 
                // rather an object stating if the command executed succesfully).
                var result = await commands.ExecuteAsync(context, pos, services);
                if (!result.IsSuccess)
                {
                    await context.Channel.SendMessageAsync(result.ErrorReason);
                }

            }
        }
    }
}
