using FluentValidation;
using NorthCashFlow.Comunication.Requests;
using NorthCashFlow.Exception;

namespace NorthCashFlow.Aplication.UseCases.Expenses.Register;

/// <summary>
///     Validator for expense registration requests.
///     This class extends the AbstractValidator from FluentValidation to define rules
///     for validating the fields of a RequestRegisterExpenseJson object. It ensures that
///     the request data meets the specified criteria before proceeding with expense registration.
/// </summary>
public class RegisterExpenseValidator : AbstractValidator<RequestRegisterExpenseJson>
{
    public RegisterExpenseValidator()
    {
        // Ensures the title is not empty
        RuleFor(request => request.Title)
            .NotEmpty()
            .WithMessage(ResourceErrorMessages.TITLE_REQUIRED);

        // Validates that the value is greater than zero
        RuleFor(request => request.Value)
            .GreaterThan(0)
            .WithMessage(ResourceErrorMessages.GREATER_THAN_ZERO);

        // Checks that the date is not in the future
        RuleFor(request => request.Date)
            .LessThanOrEqualTo(DateTime.UtcNow)
            .WithMessage(ResourceErrorMessages.FUTURE_DATE_ERROR);

        // Ensures the payment type is a valid enum value
        RuleFor(request => request.PaymentType)
            .IsInEnum()
            .WithMessage(ResourceErrorMessages.PAYMENT_TYPE_INVALID);
    }
}