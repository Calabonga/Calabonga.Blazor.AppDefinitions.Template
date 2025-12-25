using Calabonga.Blazor.AppDefinitions;
using Calabonga.Blazor.Shell.Components;

var builder = WebApplication.CreateBuilder(args);

builder.AddBlazorModulesDefinitions("Modules", typeof(App));

var app = builder.Build();

app.UseBlazorDefinitions();

app.Run();
