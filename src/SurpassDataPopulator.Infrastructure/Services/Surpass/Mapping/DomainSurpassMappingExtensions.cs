using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Humanizer;
using SurpassApiSdk.DataContracts.Item;
using SurpassApiSdk.DataContracts.Item.Details;
using SurpassApiSdk.DataContracts.Item.Details.Items;
using SurpassDataPopulator.Domain.Entities.Items;
using SurpassDataPopulator.Domain.Entities.Items.QuestionTypes.EitherOr;
using SurpassDataPopulator.Domain.Entities.Items.QuestionTypes.MultipleChoice;

namespace SurpassDataPopulator.Infrastructure.Services.Surpass.Mapping
{
    public static class DomainSurpassMappingExtensions
    {
        public static ItemInputResource ToSurpassPostDto(this Item item, string subjectReference, long folderId, int position)
        {
            var postObject = CreateStandardItem(item, subjectReference, folderId, position);
            
            switch (item)
            {
                case EitherOrItem eitherOrItem:
                    CreateEitherOrResource(eitherOrItem, postObject);
                    break;
                case MultipleChoiceItem mcq:
                    CreateMcqResource(mcq, postObject);
                    break;
                default:
                    throw new ArgumentException($"Unable to create item of type: {item.GetType()}");
            }

            return postObject;
        }

        private static void CreateMcqResource(MultipleChoiceItem mcq, ItemInputResource postObject)
        {
            var mcqOptions = mcq.AnswerOptions.Select(
                (option, index) => new ItemOptionUpdateResource
                {
                    Correct = option.CorrectAnswer,
                    Text = $"{option.Text}",
                    Id = index,
                }).ToList();

            postObject.MultipleChoiceQuestions = new List<MultipleChoiceItemUpdateResource>
            {
                new()
                {
                    Randomise = true,
                    OptionList = new ItemOptionListUpdateResource
                    {
                        Options = mcqOptions
                    }
                }
            };
        }

        private static void CreateEitherOrResource(EitherOrItem eitherOrItem, ItemInputResource postObject)
        {
            var options = new List<bool> { true, false };
            var eitherOrOptions = options.Select(o => new ItemOptionUpdateResource
                {
                    Correct = o == eitherOrItem.CorrectAnswer, 
                    Text = $"{o.ToString().Humanize(LetterCasing.Title)}",
                }).ToList();

            postObject.EitherOrQuestions = new List<EitherOrItemUpdateResource>
            {
                new()
                {
                    Randomise = true,
                    OptionList = new EOItemOptionListUpdateResource()
                    {
                        Options = eitherOrOptions
                    }
                }
            };
        }

        private static ItemInputResource CreateStandardItem(Item item, string subjectReference, long folderId, int position)
        {
            var stems = new StringBuilder();
            foreach (var questionText in item.QuestionText)
            {
                stems.Append($"{questionText}");
            }
            
            return new ItemInputResource
            {
                Subject = new ItemSubjectResource
                {
                    Reference = subjectReference
                },
                Folder = new ItemFolderResource
                {
                    Id = (int) folderId,
                    Position = position
                },
                QuestionText = stems.ToString(),
                Name = $"{item.Category.Dehumanize()} - item {Guid.NewGuid().ToString("N")} - {item.Difficulty} Difficulty",
                Mark = item.Mark,
                ItemKind = ItemKind.Question,
            };
        }
    }
}