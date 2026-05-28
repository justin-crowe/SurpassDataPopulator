using System.CommandLine;

namespace SurpassDataPopulator.Console.Cli.Verbs.Create.Subject;

public class CreateSubject : Command
{
    public Option<string> SubjectNameOption { get; }

    public Option<string> SubjectReferenceOption { get; }

    public CreateSubject(MediatrBinder mediatrBinder)
        : base("createSubject", "Create a Subject")
    {        
        SubjectNameOption = new Option<string>(
                ["--name", "-n"],
                description: "The subject name")
            { IsRequired = true };

        SubjectReferenceOption = new Option<string>(
                ["--reference", "-r"],
                description: "The subject reference")
            { IsRequired = true };
    }
}