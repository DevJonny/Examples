using FluentValidation;

public class PingValidator : AbstractValidator<Ping>
{
    public PingValidator()
    {
        RuleFor(ping => ping.Message)
            .Cascade(CascadeMode.Stop)
            .NotEmpty().WithMessage("Message is required")
            .MinimumLength(5).WithMessage("Message must be at least 5 characters");
    }
}