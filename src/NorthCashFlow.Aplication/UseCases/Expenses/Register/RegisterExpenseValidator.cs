using FluentValidation;
using NorthCashFlow.Comunication.Requests;

namespace NorthCashFlow.Aplication.UseCases.Expenses.Register;

/// <summary>
/// Validator for expense registration requests.
/// This class extends the AbstractValidator from FluentValidation to define rules
/// for validating the fields of a RequestRegisterExpenseJson object. It ensures that
/// the request data meets the specified criteria before proceeding with expense registration.
/// </summary>
public class RegisterExpenseValidator : AbstractValidator<RequestRegisterExpenseJson>
{
    public RegisterExpenseValidator()
    {
        // Ensures the title is not empty
        RuleFor(request => request.Title)
            .NotEmpty()
            .WithMessage("Title is required");

        // Validates that the value is greater than zero
        RuleFor(request => request.Value)
            .GreaterThan(0)
            .WithMessage("Value must be greater than zero");

        // Checks that the date is not in the future
        RuleFor(request => request.Date)
            .LessThanOrEqualTo(DateTime.UtcNow)
            .WithMessage("Date must be less than or equal to the current date");

        // Ensures the payment type is a valid enum value
        RuleFor(request => request.PaymentType)
            .IsInEnum()
            .WithMessage("Payment type is invalid must be between 1 and 3");
    }
}