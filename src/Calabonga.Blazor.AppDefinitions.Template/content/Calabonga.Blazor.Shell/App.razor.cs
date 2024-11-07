using System.Reflection;
using Calabonga.Blazor.AppDefinitions;
using Microsoft.AspNetCore.Components;

namespace Calabonga.Blazor.Shell;

public partial class App : ComponentBase
{
    public IEnumerable<Assembly> Modules => BlazorModules.Instance.Modules;

    //public IEnumerable<Assembly> Modules => [
    //    typeof(ModuleCounter.Counter).Assembly,
    //    typeof(ModuleIndex.Index).Assembly,
    //    typeof(ModuleWeatherForecast.FetchData).Assembly
    //];

}