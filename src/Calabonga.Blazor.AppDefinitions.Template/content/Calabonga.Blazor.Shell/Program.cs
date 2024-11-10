using Calabonga.Blazor.AppDefinitions;

namespace Calabonga.Blazor.Shell;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.AddBlazorModulesDefinitions("Modules", typeof(App));

        var app = builder.Build();

        app.UseDefinitions();

        app.Run();
    }
}