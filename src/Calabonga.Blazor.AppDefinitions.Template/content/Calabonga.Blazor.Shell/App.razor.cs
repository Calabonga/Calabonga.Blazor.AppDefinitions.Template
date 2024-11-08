using System.Reflection;
using Calabonga.Blazor.AppDefinitions;
using Microsoft.AspNetCore.Components;

namespace Calabonga.Blazor.Shell;

public partial class App : ComponentBase
{
    private IEnumerable<Assembly> Modules => ModuleDefinitions.Instance.Assemblies;
}