using Calabonga.Blazor.AppDefinitions;

namespace Calabonga.Blazor.WeatherModule;

/// <summary>
/// WeatherForecastModule with route
/// </summary>
public class WeatherForecastBlazorModule : BlazorModule
{
    public override string Title => "WeatherForecast";

    public override string Description => "Brief component description";

    public override string Route => "/fetchdata";

    public override int OrderIndex => 3;
}