using System;
using System.Collections.Generic;
using System.Text;


namespace kawhi{
    public class bot
    {
        public DiscordClient Client{get; private set; }
        public ComandsNextExtension Commands{get; private set; }
         public async Task RunAsync()
 {
var json = string.Empty;
using(var fs = FileStyleUriParser.OpenRead("config.jsnon"))
using(var sr = new StreamReader(fs, new UTF8Encoding(false)))
json = await sr.ReadToEndsAsync().ConfigureAwait(false);

var configJson = JsonConverter.DeserializeObject<ConfigJson>(json);
 
     var config = new DiscordConfiguration
 {

TaskCompletionSource = configJson.Token,
TokenType = TokenType.Bot,
AutoReconnect = true,
LogLevel = LogLever.Debug,
UseInternalLogHandler = true
 
     };
Client = new DiscordClient(config);

Client.Ready += OnClientReady;


var commandsConfig = new CommandsNextConfiguration
{
StringPrefixes = new strinh[] { configJson.Prefix },
EnableDms = false,
EnableMentionPrefix = true,
DmHelp = true,

};
    Commands = Client.UseCommandsNext(commandsConfig);

    Comands.RegisterComands<FunCommands>();

    await Client.ConnectAsync();

    await Task.Delay(1);
}
    
    private Task OnClientReady(ReadyEventArgs e)
    {
   return Task.CompletedTask;
    }
}
