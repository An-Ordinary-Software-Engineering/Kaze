using System.CommandLine;

namespace FastCLI.Application;

public class CLIApplication
{
    private const string _descriptionApp = "FastCLI - build .NET applications quickly!";
    private const string _rootCommandName = "fs";

    public static RootCommand Build()
    {
        RootCommand command = new(_descriptionApp);
        command.Name = _rootCommandName;

        return command;
    }

    public static async Task<int> InvokeAsync(RootCommand root, string[] args)
        => await root.InvokeAsync(args);
}