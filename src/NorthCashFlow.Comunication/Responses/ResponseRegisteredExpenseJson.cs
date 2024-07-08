namespace NorthCashFlow.Comunication.Responses;

/// <summary>
///     Represents the response returned after registering an expense.
/// </summary>
public class ResponseRegisteredExpenseJson
{
    /// <summary>
    ///     Gets or sets the title of the registered expense.
    /// </summary>
    /// <value>The title of the expense.</value>
    public string Title { get; set; } = string.Empty;
}