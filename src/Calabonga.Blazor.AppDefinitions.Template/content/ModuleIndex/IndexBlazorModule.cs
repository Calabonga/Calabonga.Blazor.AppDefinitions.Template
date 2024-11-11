using Calabonga.Blazor.AppDefinitions;
using Microsoft.AspNetCore.Components.Routing;

namespace ModuleIndex;

/// <summary>
/// IndexModule with route
/// </summary>
public class IndexBlazorModule : BlazorModule
{
    public override string Title => "Home";

    public override string Description => "Brief component description";

    public override string Route => "/";

    public override NavLinkMatch Match => NavLinkMatch.All;

    public override int OrderIndex => 0;
}