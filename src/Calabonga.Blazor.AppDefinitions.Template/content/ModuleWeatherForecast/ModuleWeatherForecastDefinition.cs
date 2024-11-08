using Calabonga.Blazor.AppDefinitions;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace ModuleWeatherForecast;

public class ModuleWeatherForecastDefinition : AppDefinition
{
    public override bool Exported => true;

    public override void ConfigureServices(WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IBlazorModule, WeatherForecastBlazorModule>();
        builder.Services.AddScoped<WeatherForecastService>();
    }
}