using System;
using FluentValidation;

namespace SurpassDataPopulator.Application.Authentication.Login;

public class LoginCommandValidator : AbstractValidator<LoginCommand>
{
    public LoginCommandValidator()
    {
        RuleFor(command => command.Url)
            .NotEmpty()
            .WithMessage("URL is required.")
            .Must(uri => Uri.TryCreate(uri, UriKind.Absolute, out _))
            .WithMessage("Invalid URL format.");

        RuleFor(command => command.Username).NotEmpty().WithMessage("Username is required.");

        RuleFor(command => command.Password).NotEmpty().WithMessage("Password is required.");
    }
}