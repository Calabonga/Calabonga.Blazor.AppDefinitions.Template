using Calabonga.Blazor.AppDefinitions;
using Microsoft.AspNetCore.Components.Routing;

namespace ModuleIndex;

public class IndexBlazorModule : IBlazorModule
{
    public string Title => "Home";

    public string Description => "Brief component description";

    public string Route => "/";

    public NavLinkMatch Match => NavLinkMatch.All;
}