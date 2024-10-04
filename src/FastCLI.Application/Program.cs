using System.CommandLine;
using FastCLI.Application;

RootCommand root = CLIApplication.Build();

return await root.InvokeAsync(args);
