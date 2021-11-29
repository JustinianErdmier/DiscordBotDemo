// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("StyleCop.CSharp.LayoutRules", "SA1502:Element should not be on a single line", Justification = "In this instance, the element should be on a single line.", Scope = "member", Target = "~M:DiscordBot.Data.Context.DiscordBotDbContext.#ctor(Microsoft.EntityFrameworkCore.DbContextOptions)")]
[assembly: SuppressMessage("StyleCop.CSharp.NamingRules", "SA1309:Field names should not begin with underscore", Justification = "Using underscores are the standard convention for fields.")]
[assembly: SuppressMessage("StyleCop.CSharp.ReadabilityRules", "SA1101:Prefix local calls with this", Justification = "Prefixing local calls with this does not increase readability.")]
[assembly: SuppressMessage("StyleCop.CSharp.LayoutRules", "SA1503:Braces should not be omitted", Justification = "In this instance, braces should be omitted.", Scope = "member", Target = "~M:DiscordBot.Data.DataAccessLayer.CreateGuild(System.UInt64)~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("StyleCop.CSharp.LayoutRules", "SA1520:Use braces consistently", Justification = "In this instance, braces should be omitted.", Scope = "member", Target = "~M:DiscordBot.Data.DataAccessLayer.SetPrefix(System.UInt64,System.String)~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("StyleCop.CSharp.LayoutRules", "SA1503:Braces should not be omitted", Justification = "In this instance, braces should be omitted.", Scope = "member", Target = "~M:DiscordBot.Data.DataAccessLayer.DeleteGuild(System.UInt64)~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("StyleCop.CSharp.OrderingRules", "SA1200:Using directives should be placed correctly", Justification = "CS8914:Global using directives cannot be used in a namespace declaration.")]
[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1633:File should have header", Justification = "Codebase does not have copyright. The contens within this repository are licensed as MIT")]
