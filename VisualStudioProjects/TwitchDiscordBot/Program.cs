using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;

namespace TwitchDiscordBot
{
    class Program
    {
        static void Main(string[] args)
        {
            TwitchBot tBot = new TwitchBot();
            tBot.Connect();

            DiscordBot dBot = new DiscordBot();
            new DiscordBot().MainAsync().GetAwaiter().GetResult();

            Console.ReadLine();
            tBot.Disconnect();
            
        }
    }
}
