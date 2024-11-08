using Calabonga.Blazor.AppDefinitions;
using Microsoft.AspNetCore.Components.Routing;

namespace ModuleCounter;

public class CounterBlazorModule : IBlazorModule
{
    public string Title => "Counter";

    public string Description => "Brief component description";

    public string Route => "/counter";

    public NavLinkMatch Match => NavLinkMatch.Prefix;
}