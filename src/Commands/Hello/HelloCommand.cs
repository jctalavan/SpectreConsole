// See https://aka.ms/new-console-template for more information
using Spectre.Console;
using Spectre.Console.Cli;
using System.Diagnostics.CodeAnalysis;

namespace DemoSpectreConsoleApp.Commands.Hello
{
    internal class HelloCommand : Command<HelloCommandSettings>
    {
        public override int Execute([NotNull] CommandContext context, [NotNull] HelloCommandSettings settings)
        {
            var nombre = settings.Nombre;
            var apellidos = settings.Apellidos;

            string saludo = $"[bold yellow]Hola[/]";
            saludo += $" [red]{string.Join(" ", nombre)}[/]";
            if (!string.IsNullOrWhiteSpace(apellidos))
                saludo += $"[green] {string.Join(" ", apellidos)}[/]";

            AnsiConsole.Markup(saludo);

            return 0;
        }
    }
}