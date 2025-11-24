using Calabonga.Blazor.AppDefinitions;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Calabonga.Blazor.WeatherModule;

/// <summary>
/// WeatherForecastModule Definition
/// </summary>
public class ModuleWeatherForecastDefinition : AppDefinition
{
    public override bool Exported => true;

    public override void ConfigureServices(WebApplicationBuilder builder)
    {
        // module registration
        builder.Services.AddScoped<IBlazorModule, WeatherForecastBlazorModule>();

        // module dependencies registration
        builder.Services.AddScoped<WeatherForecastService>();
    }
}