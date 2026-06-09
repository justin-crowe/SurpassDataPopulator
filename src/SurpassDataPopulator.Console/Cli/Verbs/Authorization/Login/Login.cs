using System.CommandLine;
using Spectre.Console;
using SurpassDataPopulator.Application.Authentication.Login;
using SurpassDataPopulator.Console.Display.Mappers;

namespace SurpassDataPopulator.Console.Cli.Verbs.Authorization.Login;

public class Login : Command
{
    public Login(ProgressAwareMediatrBinder mediatorBinder, IConsoleAppResultOutput<LoginCommandResult> consoleAppResultOutput) 
        : base("login", "Logs into an instance of surpass that the cli will use from now on. Use Logout to remove or call Login with the new credentials")
    {
        var urlOption = new Option<string>(["--url", "--instance", "-i"], "Surpass Instance URL - EG: https://customer.surpass.com") { IsRequired = true };
        var userOption = new Option<string>(["--user", "--username", "-u"], "Username") { IsRequired = true };
        var passOption = new Option<string?>(["--pass", "--password", "-p"], "Password (will prompt securely if not provided)") { IsRequired = false, IsHidden = true};

        AddOption(urlOption);
        AddOption(userOption);
        AddOption(passOption);

        this.SetHandler(
            async (string url, string user, string? password, ProgressAwareSender sender) =>
            {
                // Prompt for password securely if not provided via command line
                if (string.IsNullOrWhiteSpace(password))
                {
                    password = AnsiConsole.Prompt(
                        new TextPrompt<string>("Enter [green]password[/]:")
                            .PromptStyle("red")
                            .Secret());
                }

                var result = await sender.SendWithProgressAsync<LoginCommandResult>(
                    new LoginCommand(url, user, password),
                    "Logging into Surpass...");
                consoleAppResultOutput.Print(result);
            },
            urlOption, userOption, passOption, mediatorBinder);
    }
}