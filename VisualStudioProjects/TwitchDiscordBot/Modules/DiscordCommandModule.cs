using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace TwitchDiscordBot.Modules
{
    public class DiscordCommandModule : ModuleBase
    {

        [Command("say")]
        [Alias("echo")]
        [Summary("Echos the provided input")]
        public async Task Say([Remainder] string input)
        {
            await ReplyAsync(input);
        }

        [Command("greet")]
        [Alias("yo", "howdy", "sup", "hey", "hello", "hi")]
        [Summary("Greets the user back")]
        public async Task Greet()
        {
            Random rand = new Random();
            int randGreetIndex;
            string greetToPost;

                string[] randomGreets =
                    {
                        "Hi",
                        "Yo",
                        "Sup",
                        "Hey",
                        "Hello",
                        "Howdy"
                    };

            randGreetIndex = rand.Next(randomGreets.Length);
            greetToPost = randomGreets[randGreetIndex];

            await ReplyAsync($"{greetToPost}, {Context.User.Mention}!");

        }
    }
}
