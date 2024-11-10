using Calabonga.Blazor.AppDefinitions;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace ModuleCounter;

/// <summary>
/// CounterModule Definition
/// </summary>
public class ModuleCounterDefinition : AppDefinition
{
    public override bool Exported => true;

    public override void ConfigureServices(WebApplicationBuilder builder)
    {
        // module registration
        builder.Services.AddScoped<IBlazorModule, CounterBlazorModule>();

        // module dependencies registration
    }
}