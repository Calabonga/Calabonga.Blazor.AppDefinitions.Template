using Calabonga.Blazor.AppDefinitions;
using Microsoft.AspNetCore.Components.Routing;

namespace Calabonga.Blazor.Shell.Extensions;

public static class ModulesExtensions
{
    extension(IEnumerable<BlazorAppDefinition> source)
    {
        public IEnumerable<AssemblyNavLink> AsNavLinks()
        {
            return source.SelectMany(x => x.Modules).Select(x => new AssemblyNavLink(x.Route, x.Title, x.Match, x.OrderIndex));
        }
    }

}

public record AssemblyNavLink(string Route, string Title, NavLinkMatch Match = NavLinkMatch.Prefix, int OrderIndex = 0);