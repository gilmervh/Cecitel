using FluentValidation;

namespace Cecitel.Validators;

public class WeatherForecastRequest
{
    public int Days { get; set; }
}

public class WeatherForecastValidator : AbstractValidator<WeatherForecastRequest>
{
    public WeatherForecastValidator()
    {
        RuleFor(x => x.Days)
            .GreaterThan(0)
            .LessThanOrEqualTo(30)
            .WithMessage("Days must be between 1 and 30.");
    }
}
