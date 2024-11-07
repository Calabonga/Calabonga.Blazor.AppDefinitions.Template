using Microsoft.Extensions.DependencyInjection;

namespace ModuleWeatherForecast;

public static class WeatherForecastExtensions
{
    public static void AddModuleWeatherForecast(this IServiceCollection source)
    {
        source.AddSingleton<WeatherForecastService>();
    }
}