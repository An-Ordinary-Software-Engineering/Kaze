using FastCLI.Application;

var root = CLIApplication.Build();

return await CLIApplication.InvokeAsync(root, args);
