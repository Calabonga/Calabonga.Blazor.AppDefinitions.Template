using Calabonga.Blazor.AppDefinitions;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace ModuleIndex;

/// <summary>
/// IndexModule Definition
/// </summary>
public class ModuleIndexDefinition : AppDefinition
{
    public override bool Exported => true;

    public override void ConfigureServices(WebApplicationBuilder builder)
    {
        // module registration
        builder.Services.AddScoped<IBlazorModule, IndexBlazorModule>();

        // module dependencies registration
    }
}