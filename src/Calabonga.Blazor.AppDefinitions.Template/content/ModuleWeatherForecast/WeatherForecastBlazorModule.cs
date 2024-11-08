using Calabonga.Blazor.AppDefinitions;
using Microsoft.AspNetCore.Components.Routing;

namespace ModuleWeatherForecast;

public class WeatherForecastBlazorModule : IBlazorModule
{
    public string Title => "WeatherForecast";

    public string Description => "Brief component description";

    public string Route => "/fetchdata";

    public NavLinkMatch Match => NavLinkMatch.Prefix;

}