// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("StyleCop.CSharp.OrderingRules", "SA1200:Using directives should be placed correctly", Justification = "CS8914:Global using directives cannot be used in a namespace declaration.")]
[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1633:File should have header", Justification = "Codebase does not have copyright. The contens within this repository are licensed as MIT")]
[assembly: SuppressMessage("StyleCop.CSharp.LayoutRules", "SA1503:Braces should not be omitted", Justification = "In this instance, braces should be omitted.", Scope = "member", Target = "~M:DiscordBot.Models.ParseStringConverter.ReadJson(Newtonsoft.Json.JsonReader,System.Type,System.Object,Newtonsoft.Json.JsonSerializer)~System.Object")]
[assembly: SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1401:Fields should be private", Justification = "This field is public to allow accessibility to child classes.", Scope = "member", Target = "~F:DiscordBot.Modules.DiscordBotModuleBase.DataAccessLayer")]
[assembly: SuppressMessage("StyleCop.CSharp.ReadabilityRules", "SA1101:Prefix local calls with this", Justification = "Prefixing local calls with this does not increase readability.")]
[assembly: SuppressMessage("StyleCop.CSharp.NamingRules", "SA1309:Field names should not begin with underscore", Justification = "Using underscores are the standard convention for fields.")]
[assembly: SuppressMessage("StyleCop.CSharp.LayoutRules", "SA1503:Braces should not be omitted", Justification = "In this instance, braces should be omitted.", Scope = "member", Target = "~M:DiscordBot.Services.CommandHandler.OnCommandExecuted(Discord.Optional{Discord.Commands.CommandInfo},Discord.Commands.ICommandContext,Discord.Commands.IResult)~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("StyleCop.CSharp.LayoutRules", "SA1503:Braces should not be omitted", Justification = "In this instance, braces should be omitted.", Scope = "member", Target = "~M:DiscordBot.Services.CommandHandler.OnMessageReceived(Discord.WebSocket.SocketMessage)~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1401:Fields should be private", Justification = "Field will be used by inherited classes", Scope = "member", Target = "~F:DiscordBot.Services.DiscordBotService.Client")]
[assembly: SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1401:Fields should be private", Justification = "Field will be used by inherited classes", Scope = "member", Target = "~F:DiscordBot.Services.DiscordBotService.Logger")]
[assembly: SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1401:Fields should be private", Justification = "Field will be used by inherited classes", Scope = "member", Target = "~F:DiscordBot.Services.DiscordBotService.Configuration")]
[assembly: SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1401:Fields should be private", Justification = "Field will be used by inherited classes", Scope = "member", Target = "~F:DiscordBot.Services.DiscordBotService.DataAccessLayer")]
[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:Elements should be documented", Justification = "A quicktype.io provided class that handles JSON conversion to and from C#.", Scope = "type", Target = "~T:DiscordBot.Models.Converter")]
[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:Elements should be documented", Justification = "A quicktype.io provided class that handles JSON conversion to and from C#.", Scope = "type", Target = "~T:DiscordBot.Models.Serialize")]
[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:Elements should be documented", Justification = "A quicktype.io provided class that handles JSON conversion to and from C#.", Scope = "type", Target = "~T:DiscordBot.Models.ParseStringConverter")]
[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:Elements should be documented", Justification = "No documentation needed.", Scope = "member", Target = "~F:DiscordBot.Services.DiscordBotService.Client")]
[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:Elements should be documented", Justification = "No documentation needed.", Scope = "member", Target = "~F:DiscordBot.Services.DiscordBotService.Logger")]
[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:Elements should be documented", Justification = "No documentation needed.", Scope = "member", Target = "~F:DiscordBot.Services.DiscordBotService.Configuration")]
[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:Elements should be documented", Justification = "No documentation needed.", Scope = "member", Target = "~F:DiscordBot.Services.DiscordBotService.DataAccessLayer")]
