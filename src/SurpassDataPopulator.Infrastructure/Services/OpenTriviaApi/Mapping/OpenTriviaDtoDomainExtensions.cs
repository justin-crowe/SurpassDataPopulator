using System;
using System.Collections.Generic;
using System.Linq;
using SurpassDataPopulator.Domain.Data.Builders.Items;
using SurpassDataPopulator.Domain.Entities.Items;
using SurpassDataPopulator.Domain.Entities.Items.QuestionTypes.EitherOr;
using SurpassDataPopulator.Domain.Entities.Items.QuestionTypes.MultipleChoice;
using SurpassDataPopulator.Domain.Entities.Tags;
using SurpassDataPopulator.Infrastructure.Services.OpenTriviaApi.Dto;

namespace SurpassDataPopulator.Infrastructure.Services.OpenTriviaApi.Mapping
{
    //TODO use a mapper lib?
    public static class OpenTriviaDtoDomainExtensions
    {
        public static ItemBuildResult ToItemGenerationResult(this List<ApiResponse> responses, ItemBuildRequest request)
        {
            var items = new List<Item>();
            
            responses.ForEach(x =>
            {
                items.AddRange(ConvertOpenTriviaItems(x, request));
            });

            return new ItemBuildResult
            {
                Items = items
            };
        }

        private static IEnumerable<Item> ConvertOpenTriviaItems(ApiResponse response, ItemBuildRequest request)
        {
            var items = new List<Item>();
            foreach (var question in response.OpenTriviaQuestions)
            {
                var item = question.Type switch
                {
                    QuestionTypes.MultipleChoice => ConvertToMultipleChoiceItem(question),
                    QuestionTypes.Boolean => ConvertToEitherOrItem(question),
                    _ => throw new NullReferenceException($"Cannot create item for open trivia type: {question.Type}")
                };

                item.Mark = 1;
                item.QuestionText = ConvertQuestionStems(question, request);
                item.Category = question.Category; //TODO convert to standard metadata
                item.Difficulty = (Difficulty) question.Difficulty; //TODO convert to standard metadata
                item.Type = ConvertItemType(question.Type);
                item.Tags = AddTags(request, item);
                items.Add(item);
            }

            return items;
        }

        private static List<Tag> AddTags(ItemBuildRequest request, Item item)
        {
            return !request.Tags.Any() 
                ? new List<Tag>() 
                : request.Tags.Select(tagRequest => tagRequest.Build(item)).ToList();
        }

        private static ItemType ConvertItemType(string questionType)
        {
            return questionType.ToLower() switch
            {
                "multiple" => ItemType.MultipleChoice,
                "boolean" => ItemType.EitherOr,
                _ => throw new ArgumentException($"Cannot map {questionType} to domain ItemType")
            };
        }

        private static List<string> ConvertQuestionStems(QuestionResponse question, ItemBuildRequest itemBuildRequest)
        {
            var stems = new List<string> { $"<p><b>{question.Question}</b></p>" };

            if (!itemBuildRequest.DisplayCorrectAnswer) return stems;
            
            //TODO display this nicely.. organise so the spoiler is always at the bottom of the stem?
            var spoiler = 
                "<hr/>" +
                "<p align=\"right\">Answer:</p>" +
                $"<p align=\"right\"><sub>{question.CorrectAnswer}</sub></p>" +
                "<hr/>";
                
            stems.Add(spoiler);

            return stems;
        }

        private static Item ConvertToEitherOrItem(QuestionResponse question)
        {
            var item = new EitherOrItem
            {
                CorrectAnswer = Convert.ToBoolean(question.CorrectAnswer)
            };
            return item;
        }
        
        private static Item ConvertToMultipleChoiceItem(QuestionResponse question)
        {
            var options = question.IncorrectAnswers.Select(
                ans => new MultipleChoiceItemOption
                {
                    Text = ans, 
                    CorrectAnswer = false
                }).ToList();

            options.Add(new MultipleChoiceItemOption
            {
                Text = question.CorrectAnswer, 
                CorrectAnswer = true
            });

            Item item = new MultipleChoiceItem
            {
                AnswerOptions = options
            };
            
            return item;
        }
    }
}