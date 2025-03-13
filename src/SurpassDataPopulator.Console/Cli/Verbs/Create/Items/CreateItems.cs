using System.Collections.Generic;
using CommandLine;

namespace SurpassDataPopulator.Console.Cli.Verbs.Create.Items;

[Verb("createItems", HelpText = "Add items to a subject.")]
public class CreateItems
{
    [Option('s', "subjectRef", Required = true, HelpText = "The subjectRef")]
    public string SubjectRef { get; set; }

    [Option('n', "numberOfItemsPerCategory", Required = true, HelpText = "The number of items per category")]
    public int NumberOfQuestions { get; set; }

    [Option('c', "category", Required = false, HelpText = "The open trivia category", Default = default)]
    public IEnumerable<int> Category { get; set; }

    [Option("showCorrect", Required = false, HelpText = "Is the correct answer added to the stem", Default = true)]
    public bool ShowCorrectAnswer { get; set; }
        
    [Option("tags", Required = false, HelpText = "Tags to add to each item. Use the format 'name:value' for static tags", Default = default)]
    public IEnumerable<string> Tags { get; set; }

    [Option("mediaFolder", Required = false, HelpText = "A path to a folder where media is stored. Images are only supported and a random image from this folder will be added to each item.", Default = default)]
    public string MediaFolder { get; set; }

    [Option("mediaItems", Required = false, HelpText = "Number of media items from the MediaFolder to assign to each item", Default = default)]
    public int NumberOfMediaItemsPerItem { get; set; }

    [Option("fixedMedia", Required = false, HelpText = "If true, the number of media items per item will be fixed to the value of 'mediaItems'. If false, a random number (0 - 'mediaItems') of media items will be assigned to each item.", Default = false)]
    public bool FixedNumberOfMediaPerItem { get; set; }
}