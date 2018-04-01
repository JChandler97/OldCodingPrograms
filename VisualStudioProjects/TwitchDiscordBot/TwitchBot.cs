using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchLib;
using TwitchLib.Models.Client;
using TwitchLib.Events.Client;
using TwitchLib.Models.API.v5.Users;

namespace TwitchDiscordBot
{
    internal class TwitchBot
    {
        readonly ConnectionCredentials credentials = new ConnectionCredentials(TwitchBotInfo.BotUsername, TwitchBotInfo.BotToken);
        TwitchClient client;

        internal void Connect()
        {
            Console.WriteLine("Connecting to Twitch!");
            client = new TwitchClient(credentials, TwitchBotInfo.ChannelName);

            Console.WriteLine("Connected to " + TwitchBotInfo.ChannelName);

            client.ChatThrottler = new TwitchLib.Services.MessageThrottler(20, TimeSpan.FromSeconds(30));
            client.WhisperThrottler = new TwitchLib.Services.MessageThrottler(20, TimeSpan.FromSeconds(30));

            client.OnLog += Client_OnLog;
            client.OnConnectionError += Client_OnConnectionError;
            client.OnMessageReceived += Client_OnMessageReceived;
            client.OnWhisperReceived += Client_OnWhisperReceived;
            client.Connect();

            TwitchAPI.Settings.ClientId = TwitchBotInfo.ClientId;
        }

        private void Client_OnLog(object sender, OnLogArgs e)
        {
            Console.WriteLine(e.Data);
        }

        private void Client_OnMessageReceived(object sender, OnMessageReceivedArgs e)
        {
            if(e.ChatMessage.Message.StartsWith("hi", StringComparison.InvariantCultureIgnoreCase))
            {
                client.SendMessage($"@{e.ChatMessage.DisplayName} Yo!");
            }

            if(e.ChatMessage.Message.StartsWith("!disconnect", StringComparison.InvariantCultureIgnoreCase))
            {
                if (e.ChatMessage.IsBroadcaster)
                {
                    Disconnect();
                }
                else
                {
                    client.SendMessage($"@{e.ChatMessage.DisplayName} You can't take me alive! DansGame");
                }
            }

            // The stream has been live for: [time here] | Shul began streaming on {e.[StreamStats]}.
            // { 0:% h}h { 0:% m}m { 0:% s}s
            // @"'The stream has been live for:' hh\:mm\:ss"
            // "mm':'ss' minutes'"

            if (e.ChatMessage.Message.StartsWith("!uptime", StringComparison.InvariantCultureIgnoreCase))
            {
                client.SendMessage(GetUptime()?.ToString("'The stream has been live for: 'hh':'mm':'ss' | Shul began streaming on March 16, 2017.'") ?? "Offline");

            }
        }
        
        TimeSpan? GetUptime()
        {
            string userID = GetUserID(TwitchBotInfo.ChannelName);
            if(userID == null)
            {
                return null;
            }

            return TwitchAPI.Streams.v5.GetUptime(userID).Result;
        }

        string GetUserID(string username)
        {
            User[] userlist = TwitchAPI.Users.v5.GetUserByName(username).Result.Matches;
            if(userlist == null || userlist.Length == 0)
            {
                return null;
            }

            return userlist[0].Id;
        }

        private void Client_OnConnectionError(object sender, OnConnectionErrorArgs e)
        {
            Console.WriteLine($"Error: {e.Error}");
        }

        private void Client_OnWhisperReceived(object sender, OnWhisperReceivedArgs e)
        {
            client.SendWhisper(e.WhisperMessage.Username, "I'm a bot and I don't know what you've said. I'm telling papa on you! SwiftRage");
            Console.WriteLine($"{e.WhisperMessage.Username} whispered: {e.WhisperMessage.Message}");
        }

        internal void Disconnect()
        {
            Console.WriteLine("Disconnecting from Twitch!");
        }
    }
}