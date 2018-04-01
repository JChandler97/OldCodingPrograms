using System;
using System.Collections.Generic;
using System.Text;
using Discord.Commands;
using System.Threading.Tasks;
using System.Linq;
using Discord;
using Discord.WebSocket;

namespace DiscordRoleBot
{
    public class RoleRegulation : ModuleBase
    {
        [Command("give")]
        [Summary("I mean, this is the only thing I know how to do! I've trained all my life to dedicate myself to assign roles to the nonmembers! Don't you discredit my art, you troglodite! :triumph:")]
        public async Task RoleAsync(string assignRole)
        {
            if (Context.Channel.Name == "i-read-the-info")
            {
                var user = Context.User;
                switch (assignRole)
                {
                    
                    case "Community":
                    case "community":
                        if (user.Status == UserStatus.Online || (user.Status == UserStatus.Idle) || (user.Status == UserStatus.AFK) || (user.Status == UserStatus.DoNotDisturb))
                        {
                            var role = Context.Guild.Roles.FirstOrDefault(x => x.Name == "Community");
                            await (user as IGuildUser).AddRoleAsync(role);
                            await ReplyAsync($"{user.Mention}, your role was successfully updated! Enjoy your time!");
                        }
                        else
                        {
                            await ReplyAsync($"{Context.User.Mention}, please turn your status to Online so I could update your role. :wink:");
                        }
                        break;

                    default:
                        if (user.Status == UserStatus.Online || (user.Status == UserStatus.Idle) || (user.Status == UserStatus.AFK) || (user.Status == UserStatus.DoNotDisturb))
                        {
                            await ReplyAsync($"{Context.User.Mention}, you might want to check the spelling.");
                        }
                        else
                        {
                            await ReplyAsync($"{Context.User.Mention}, please turn your status to Online so I could update your role and check your spelling! :wink:");
                        }
                        break;
                }
            }
        }
    }
}
