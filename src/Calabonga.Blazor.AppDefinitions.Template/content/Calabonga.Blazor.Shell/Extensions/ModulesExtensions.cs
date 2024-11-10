using Calabonga.Blazor.AppDefinitions;
using Microsoft.AspNetCore.Components.Routing;

namespace Calabonga.Blazor.Shell.Extensions;

public static class ModulesExtensions
{
    /// <summary>
    /// Transpose metadata <see cref="BlazorModule"/> into <see cref="NavLink"/> items
    /// </summary>
    /// <param name="source"></param>
    /// <returns>collection of the <see cref="NavLink"/></returns>
    public static IEnumerable<AssemblyNavLink> AsNavLinks(this IEnumerable<BlazorAppDefinition> source)
    {
        return source.SelectMany(x => x.Modules).Select(x => new AssemblyNavLink(x.Route, x.Title, x.Match)).ToList();
    }
}

/// <summary>
/// Represents an assembly navigation link accordant with route defined in module
/// </summary>
/// <param name="Route">route from <see cref="BlazorModule"/></param>
/// <param name="Title">title from <see cref="BlazorModule"/></param>
/// <param name="Match">match link type from <see cref="BlazorModule"/></param>
public record AssemblyNavLink(string Route, string Title, NavLinkMatch Match = NavLinkMatch.Prefix);