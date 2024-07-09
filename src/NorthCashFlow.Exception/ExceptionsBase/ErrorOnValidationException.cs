namespace NorthCashFlow.Exception.ExceptionsBase;

/// <summary>
///     Represents a validation exception specific to the NorthCashFlow project.
///     This exception is thrown when validation errors occur, encapsulating the list of error messages.
/// </summary>
public class ErrorOnValidationException : NorthCashFlowException
{
    /// <summary>
    ///     Gets or sets the list of error messages associated with the validation errors.
    /// </summary>
    public List<string> Errors { get; set; }

    /// <summary>
    ///     Initializes a new instance of the <see cref="ErrorOnValidationException" /> class with the specified error
    ///     messages.
    /// </summary>
    /// <param name="errorMessages">The list of error messages associated with the validation errors.</param>
    public ErrorOnValidationException(List<string> errorMessages)
    {
        Errors = errorMessages;
    }
}