// See https://aka.ms/new-console-template for more information
using DemoSpectreConsoleApp.Commands.Hello;
using Spectre.Console.Cli;

var app = new CommandApp();

app.Configure(config =>
{
    config.AddHelloCommandConfig();

    //config.AddCommand<HelloCommand>("hello")
    //    .WithAlias("hola")
    //    .WithDescription("Decir hola a la persona indicada")
    //    .WithExample(new[] { "hello", "Juan Carlos" })
    //    .WithExample(new[] { "hola", "Juan Carlos", "-a", "Talavan" })
    //    .WithExample(new[] { "hola", "Juan Carlos", "--apellidos", "Talavan Canelo" });
});

return app.Run(args);