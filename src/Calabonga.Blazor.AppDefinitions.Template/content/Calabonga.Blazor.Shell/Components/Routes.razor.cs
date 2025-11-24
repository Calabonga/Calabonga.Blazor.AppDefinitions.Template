using Calabonga.Blazor.AppDefinitions;
using System.Reflection;

namespace Calabonga.Blazor.Shell.Components;

public partial class Routes
{
    private IEnumerable<Assembly> Assemblies => ModuleDefinitions.Instance.Assemblies;
}