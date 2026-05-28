using System.Collections.Generic;
using SurpassDataPopulator.Domain.Entities.Items;
using SurpassDataPopulator.Infrastructure.Services.OpenTriviaApi.Dto;

namespace SurpassDataPopulator.Application.IntegrationTests.Builders;

/// <summary>
/// Builder for creating mock OpenTrivia API question responses.
/// </summary>
public class OpenTriviaQuestionBuilder
{
    private string _category = "General Knowledge";
    private string _type = "multiple";
    private QuestionDifficulty _difficulty = QuestionDifficulty.Easy;
    private string _question = "What is the capital of France?";
    private string _correctAnswer = "Paris";
    private List<string> _incorrectAnswers = ["London", "Berlin", "Madrid"];

    public OpenTriviaQuestionBuilder WithCategory(string category)
    {
        _category = category;
        return this;
    }

    public OpenTriviaQuestionBuilder WithType(string type)
    {
        _type = type;
        return this;
    }

    public OpenTriviaQuestionBuilder WithDifficulty(QuestionDifficulty difficulty)
    {
        _difficulty = difficulty;
        return this;
    }

    public OpenTriviaQuestionBuilder WithQuestion(string question)
    {
        _question = question;
        return this;
    }

    public OpenTriviaQuestionBuilder WithCorrectAnswer(string correctAnswer)
    {
        _correctAnswer = correctAnswer;
        return this;
    }

    public OpenTriviaQuestionBuilder WithIncorrectAnswers(params string[] incorrectAnswers)
    {
        _incorrectAnswers = [..incorrectAnswers];
        return this;
    }

    public OpenTriviaQuestionBuilder AsBooleanQuestion()
    {
        _type = "boolean";
        _incorrectAnswers = ["False"];
        _correctAnswer = "True";
        return this;
    }

    public QuestionResponse Build()
    {
        return new QuestionResponse
        {
            Category = _category,
            Type = _type,
            Difficulty = _difficulty,
            Question = _question,
            CorrectAnswer = _correctAnswer,
            IncorrectAnswers = _incorrectAnswers
        };
    }

    public static QuestionResponse DefaultQuestion() => new OpenTriviaQuestionBuilder().Build();

    public static List<QuestionResponse> CreateMultiple(int count)
    {
        var questions = new List<QuestionResponse>();
        for (int i = 0; i < count; i++)
        {
            questions.Add(new OpenTriviaQuestionBuilder()
                .WithQuestion($"Test Question {i + 1}?")
                .WithCorrectAnswer($"Answer {i + 1}")
                .Build());
        }
        return questions;
    }
}
