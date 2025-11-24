using Calabonga.Blazor.AppDefinitions;
using Microsoft.AspNetCore.Components.Routing;

namespace Calabonga.Blazor.CounterModule;

public class CounterBlazorModule : IBlazorModule
{
    public bool IsHidden
        => false;

    public int OrderIndex
        => 0;

    public string Title
        => "Counter";

    public string Description
        => "Just a counter";

    public string Route => "/counter";

    public NavLinkMatch Match
        => NavLinkMatch.Prefix;
}