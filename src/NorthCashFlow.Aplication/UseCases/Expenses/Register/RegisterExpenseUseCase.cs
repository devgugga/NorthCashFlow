using NorthCashFlow.Comunication.Requests;
using NorthCashFlow.Comunication.Responses;

namespace NorthCashFlow.Aplication.UseCases.Expenses.Register;

/// <summary>
///     Handles the registration of an expense.
///     This class is responsible for executing the operation of registering an expense
///     based on the provided request details. It validates the request using a dedicated
///     validator and returns a response indicating the outcome of the registration process.
/// </summary>
public class RegisterExpenseUseCase
{
    /// <summary>
    ///     Executes the use case with the given request.
    ///     This method takes a request object containing the details of the expense to be registered,
    ///     validates the request, and returns a response object indicating the result of the registration.
    /// </summary>
    /// <param name="request">The request containing the expense details to register.</param>
    /// <returns>A response indicating the result of the registration.</returns>
    /// <exception cref="ArgumentException">Thrown when the request contains invalid data.</exception>
    public ResponseRegisteredExpenseJson Execute(RequestRegisterExpenseJson request)
    {
        Validate(request);

        // Registration logic would go here

        return new ResponseRegisteredExpenseJson();
    }

    /// <summary>
    ///     Validates the provided request.
    ///     This method uses a validator to check the request for any invalid data.
    ///     If the validation fails, it throws an ArgumentException with the validation error message.
    /// </summary>
    /// <param name="request">The request to validate.</param>
    /// <exception cref="ArgumentException">Thrown when validation fails.</exception>
    private void Validate(RequestRegisterExpenseJson request)
    {
        #region Variables

        var validator = new RegisterExpenseValidator();
        var result = validator.Validate(request);

        #endregion

        if (!result.IsValid)
            result.Errors.Select(f => f.ErrorMessage).ToList().ForEach(f => throw new ArgumentException(f));
    }
}