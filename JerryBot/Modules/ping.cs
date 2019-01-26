using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace JerryBot.Modules
{
    //ping 1
    public class GhostPings : ModuleBase<SocketCommandContext>
    {
        bool ghost = false;
        [Command("lock")] //locking ghostpinging
        public async Task LockGhost()
        {
            if (ghost)
            {
                await ReplyAsync("Ghostpinging turned off.");
            }
            else if (!ghost)
            {
                await ReplyAsync("Ghostpinging active.");
            }
            ChangeGhost();
        }

        public void ChangeGhost()
        {
            ghost = !ghost;
        }

        [Command("ghost")] //check status of ghost
        public async Task ghostStatus()
        {
            if (ghost)
            {
                await ReplyAsync("ghost true");
            }
            else if (!ghost)
            {
                await ReplyAsync("ghost false");
            }
        }


        [Command("megan")] //ghostping megan

        public async Task PingMegan()
        {
            await ReplyAsync("<@350399831598039053>");
            //await ReplyAsync("yes");
            var messages = await Context.Channel.GetMessagesAsync(2).Flatten();
            await Context.Channel.DeleteMessagesAsync(messages);
        }

        [Command("irina")] //ghostping irina

        public async Task PingIrina()
        {
            await ReplyAsync("<@330948980546469888>");

            var messages = await Context.Channel.GetMessagesAsync(2).Flatten();
            await Context.Channel.DeleteMessagesAsync(messages);
        }

        [Command("katie")] //ghostping katie

        public async Task PingKatie()
        {
            await ReplyAsync("<@397109394489212928>");

            var messages = await Context.Channel.GetMessagesAsync(2).Flatten();
            await Context.Channel.DeleteMessagesAsync(messages);
        }

        [Command("sagoh")] //ghostping sagoh

        public async Task PingSagoh()
        {
            await ReplyAsync("<@484245798272499742>");

            var messages = await Context.Channel.GetMessagesAsync(2).Flatten();
            await Context.Channel.DeleteMessagesAsync(messages);
        }

        [Command("worx")] //ghostping worx

        public async Task PingWorx()
        {
            await ReplyAsync("<@88039011225968640>");

            var messages = await Context.Channel.GetMessagesAsync(2).Flatten();
            await Context.Channel.DeleteMessagesAsync(messages);
        }

        [Command("jerry")] //ghostping jerry

        public async Task PingJerry()
        {
            await ReplyAsync("<@355941913326518285>");

            var messages = await Context.Channel.GetMessagesAsync(2).Flatten();
            await Context.Channel.DeleteMessagesAsync(messages);
        }

    }

    //delete messages
    public class delMessages : ModuleBase<SocketCommandContext>
    {
        [Command("delete")] //delete lines
        [RequireUserPermission(Discord.ChannelPermission.ManageMessages)]
        public async Task Delete(int n)
        {
            var messages = await Context.Channel.GetMessagesAsync(n+1).Flatten();
            await Context.Channel.DeleteMessagesAsync(messages);
        }
    }

    //nuke server
    
    public class spam : ModuleBase<SocketCommandContext>
    {
        private static Timer t;
        [Command("spam")] //spam on intervals

        public async Task PingAsync()
        {
            t = new System.Timers.Timer();
            t.Interval = 2000;
            t.Elapsed += OnTimedEvent;
            t.Enabled = true;
        }
        //also nuke server
        private async void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            await ReplyAsync("spam");
        }

    }
    

    public class Kick : ModuleBase<SocketCommandContext>
    {
        [Command("kick")]
        [RequireUserPermission(Discord.GuildPermission.KickMembers)]
        public async Task KickUser(SocketGuildUser userName)
        {
            var user = Context.User as SocketGuildUser;
            var role = (user as IGuildUser).Guild.Roles.FirstOrDefault(x => x.Name == "Role");
            if (!userName.Roles.Contains(role))
            {
                await userName.KickAsync();
                await ReplyAsync(userName + " kicked from server");
            }
        }
    }

    //blackmail
    public class bm : ModuleBase<SocketCommandContext>
    {
        [Command("bm")]
        [RequireUserPermission(Discord.GuildPermission.ManageRoles)]
        public async Task bmUser(SocketGuildUser userName)
        {
            var user = userName;
            var role = Context.Guild.Roles.FirstOrDefault(x => x.Name == "black male'd");
            await (user as IGuildUser).AddRoleAsync(role);
            await ReplyAsync(userName + " black male'd");
        }
    }

    //unblackmail
    public class nobm : ModuleBase<SocketCommandContext>
    {
        [Command("nobm")]
        [RequireUserPermission(Discord.GuildPermission.ManageRoles)]
        public async Task nobmUser(SocketGuildUser userName)
        {
            var user = userName;
            var role = Context.Guild.Roles.FirstOrDefault(x => x.Name == "black male'd");
            await (user as IGuildUser).RemoveRoleAsync(role);
            await ReplyAsync(userName + " no longer black male'd");
        }
    }

    //pls
    public class herro : ModuleBase<SocketCommandContext>
    {
        [Command("e")]
        public async Task pls()
        {
            await ReplyAsync("Eric its past your bedtime\n");
            //await ReplyAsync("<@330948980546469888> help pls");
        }
    }

    //pls
    public class hello : ModuleBase<SocketCommandContext>
    {
        [Command("f")]
        public async Task pls()
        {
            await ReplyAsync("Irina go do your homework");
        }
    }

    public class iw : ModuleBase<SocketCommandContext>
    {
        [Command("l")]
        public async Task pls()
        {
            await ReplyAsync("Irina go to sleep");
        }
    }

    //messing around
    public class hewwo : ModuleBase<SocketCommandContext>
    {
        [Command("she")]
        public async Task she1()
        {
            await ReplyAsync("you gtfo away from me you cock pos player with no life. it's a GAME and yeah I invited my online FRIEND to this server for other PLAYERS to hang out. get over yourself and find something better to do with your life than trash others because of a stupid ratio and give yourself a lil boost on something that won't improve your work/love life in any case and is purely for fun. grow up. get a job. get a husband. make some kids. let THEM deal with this online FANTASY game and put your head back in the REAL world and try to accomplish REAL goals.");
        }
        [Command("she")]
        public async Task she(SocketGuildUser userName)
        {
            string id = userName.Id.ToString();
            await ReplyAsync( "<@" + id + "> you gtfo away from me you cock pos player with no life. it's a GAME and yeah I invited my online FRIEND to this server for other PLAYERS to hang out. get over yourself and find something better to do with your life than trash others because of a stupid ratio and give yourself a lil boost on something that won't improve your work/love life in any case and is purely for fun. grow up. get a job. get a husband. make some kids. let THEM deal with this online FANTASY game and put your head back in the REAL world and try to accomplish REAL goals.");
        }
    }

    //shutting someone up
    public class stfuu : ModuleBase<SocketCommandContext>
    {
        [Command("stfu")]
        public async Task stfu1()
        {
            await ReplyAsync("shut the fuck up");
        }
        [Command("stfu")]
        public async Task stfu(SocketGuildUser userName)
        {
            string id = userName.Id.ToString();
            await ReplyAsync("shut the fuck up <@" + id + ">");
        }
    }
    //pls
    public class em : ModuleBase<SocketCommandContext>
    {
        [Command("g")]
        public async Task emm()
        {
            await ReplyAsync("Hi VINH!!!!");
        }
    }

    //purging a channel
    public class purge : ModuleBase<SocketCommandContext>
    {
        DiscordSocketClient _user;

        [Command("purge")]
        [RequireUserPermission(Discord.ChannelPermission.ManageMessages)]
        
        public async Task sure()
        {
            string id = _user.CurrentUser.Id.ToString();
            await ReplyAsync("Are you sure? <@" + id + ">");
            //var message = await Context.Channel.GetMessagesAsync(1);

        }
        public async Task Delete()
        {
            
            var messages = await Context.Channel.GetMessagesAsync(1000).Flatten();
            await Context.Channel.DeleteMessagesAsync(messages);
        }
    }
    //jailing
    public class jail : ModuleBase<SocketCommandContext>
    {
        [Command("jail")]
        //[RequireUserPermission(Discord.GuildPermission.ManageRoles)]

        public async Task jailUser(SocketGuildUser userName)
        {
            var CommandUser = Context.Guild.GetUser(Context.User.Id);
            var userRole = Context.Guild.Roles.FirstOrDefault(x => x.Name == "BIG BULLY");
            if (CommandUser.Roles.Contains(userRole) || CommandUser.GuildPermissions.ManageRoles)
            {
                var user = userName;
                var role = Context.Guild.Roles.FirstOrDefault(x => x.Name == "jailed");
                var role2 = Context.Guild.Roles.FirstOrDefault(x => x.Name == "lllllllllllllllllllll");
                var role3 = Context.Guild.Roles.FirstOrDefault(x => x.Name == "i call jerry at night");
                var role4 = Context.Guild.Roles.FirstOrDefault(x => x.Name == "im legal");
                var role5 = Context.Guild.Roles.FirstOrDefault(x => x.Name == "programmer");
                var role6 = Context.Guild.Roles.FirstOrDefault(x => x.Name == "Honesty hour");
                if (user.Roles.Contains(role))
                {
                    await (user as IGuildUser).RemoveRoleAsync(role);
                    await ReplyAsync(userName + " released from jail");
                }
                else
                {
                    await (user as IGuildUser).AddRoleAsync(role);
                    await ReplyAsync(userName + " jailed");
                    await (user as IGuildUser).RemoveRoleAsync(role2);
                    await (user as IGuildUser).RemoveRoleAsync(role3);
                    await (user as IGuildUser).RemoveRoleAsync(role4);
                    await (user as IGuildUser).RemoveRoleAsync(role5);
                    await (user as IGuildUser).RemoveRoleAsync(role6);
                }
            }
        }

      
    }
    public class hh : ModuleBase<SocketCommandContext>
    {
        [Command("hh")]
        public async Task honestyhour()
        {
            var user = Context.User;
            var role = Context.Guild.Roles.FirstOrDefault(x => x.Name == "Honesty hour");
            if (Context.Guild.GetUser(user.Id).Roles.Contains(role))
            {
                await (user as IGuildUser).RemoveRoleAsync(role);
                await ReplyAsync(user.Mention + " has exited Honesty Hour!");
            }
            else
            {
                await (user as IGuildUser).AddRoleAsync(role);
                await ReplyAsync(user.Mention + " is now in Honesty Hour!");
            }
        }

        [Command("hh")]
        [RequireUserPermission(Discord.GuildPermission.ManageRoles)]
        public async Task honestyhour(SocketGuildUser userName)
        {
            var user = userName;
            var role = Context.Guild.Roles.FirstOrDefault(x => x.Name == "Honesty hour");
            if (Context.Guild.GetUser(user.Id).Roles.Contains(role))
            {
                await (user as IGuildUser).RemoveRoleAsync(role);
                await ReplyAsync(user.Mention + " has exited Honesty Hour!");
            }
            else
            {
                await (user as IGuildUser).AddRoleAsync(role);
                await ReplyAsync(user.Mention + " is now in Honesty Hour!");
            }
        }
    }
    public class samplepuzzle : ModuleBase<SocketCommandContext>
    {
        [Command("5")]
        public async Task emm()
        {
            await ReplyAsync("Congratulations! You have solved the first stage!");
            await ReplyAsync("Happy birthday Irina -- Jerry");
        }
    }
}
