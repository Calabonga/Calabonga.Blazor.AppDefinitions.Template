using Calabonga.Blazor.AppDefinitions;

namespace ModuleCounter;

/// <summary>
/// Counter module with route
/// </summary>
public class CounterBlazorModule : BlazorModule
{
    public override string Title => "Counter";

    public override string Description => "Brief component description";

    public override string Route => "/counter";
}