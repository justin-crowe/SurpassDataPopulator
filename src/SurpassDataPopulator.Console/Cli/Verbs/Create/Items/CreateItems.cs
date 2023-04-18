using System.Collections.Generic;
using CommandLine;

namespace SurpassDataPopulator.Console.Cli.Verbs.Create.Items
{
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
    }
}