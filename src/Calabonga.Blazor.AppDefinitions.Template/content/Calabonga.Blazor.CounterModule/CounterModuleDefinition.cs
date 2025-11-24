using Calabonga.Blazor.AppDefinitions;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Calabonga.Blazor.CounterModule;

public class CounterModuleDefinition : AppDefinition
{
    public override bool Exported
        => true;

    public override void ConfigureServices(WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IBlazorModule, CounterBlazorModule>();
    }
}