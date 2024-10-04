using System.CommandLine;

namespace FastCLI.Application;

internal class CLIApplication
{
    private const string _descriptionApp = "FastCLI - build .NET applications quickly!";
    private const string _rootCommandName = "fast";

    internal static RootCommand Build()
    {
        RootCommand command = new(_descriptionApp);
        command.Name = _rootCommandName;

        return command;
    }
}