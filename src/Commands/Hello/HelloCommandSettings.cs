using Spectre.Console;
using Spectre.Console.Cli;
using System.ComponentModel;

namespace DemoSpectreConsoleApp.Commands.Hello
{
    internal sealed class HelloCommandSettings : CommandSettings
    {
        [CommandArgument(0, "<nombre>")]
        [Description("Parámetro 'nombre'")]
        public string Nombre { get; set; } = string.Empty;

        [CommandOption("-a|--apellidos")]
        [Description("Parámetro 'apellidos'")]
        public string? Apellidos { get; set; }

        public override ValidationResult Validate()
        {
            return string.IsNullOrWhiteSpace(Nombre) || Nombre.Length < 2
                ? ValidationResult.Error("El nombre debe indicarse y tiene que tener al menos dos caracteres")
                : ValidationResult.Success();
        }
    }
}
