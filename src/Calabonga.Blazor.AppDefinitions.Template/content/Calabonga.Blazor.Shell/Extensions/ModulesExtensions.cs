using Calabonga.Blazor.AppDefinitions;
using Microsoft.AspNetCore.Components.Routing;

namespace Calabonga.Blazor.Shell.Extensions;

public static class ModulesExtensions
{
    public static IEnumerable<AssemblyNavLink> AsNavLinks(this IEnumerable<BlazorAppDefinition> source)
    {
        return source.SelectMany(x => x.Modules).Select(x => new AssemblyNavLink(x.Route, x.Title, x.Match)).ToList();
    }
}

public record AssemblyNavLink(string Route, string Title, NavLinkMatch Match = NavLinkMatch.Prefix);