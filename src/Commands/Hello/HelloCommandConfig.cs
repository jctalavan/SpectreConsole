using Spectre.Console.Cli;

namespace DemoSpectreConsoleApp.Commands.Hello
{
    internal static class HelloCommandConfig
    {
        internal static void AddHelloCommandConfig(this IConfigurator configurator)
        {
            configurator.AddCommand<HelloCommand>("hello")
                .WithAlias("hola")
                .WithDescription("Decir hola a la persona indicada")
                .WithExample(new[] { "hello", "Juan Carlos" })
                .WithExample(new[] { "hola", "Juan Carlos", "-a", "Talavan" })
                .WithExample(new[] { "hola", "Juan Carlos", "--apellidos", "Talavan Canelo" });
        }
    }
}
