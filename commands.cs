using System;
using System.Collections.Generic;
using System.Text;

namespace kawhi
{
    public class FunCommands: BaseCommandModule
    {
        [Command("ping")]
public async Task Ping(CommandContext ctx)
{
    await ctx.Channel.SendMessageAsync("Pong").ConfigureAwait(false);

}
    }
}