using NorthCashFlow.Comunication.Enums;

namespace NorthCashFlow.Comunication.Requests;

/// <summary>
///     Represents a request for registering an expense.
/// </summary>
public class RequestRegisterExpenseJson
{
    /// <summary>
    ///     Gets or sets the title of the expense.
    /// </summary>
    /// <value>The title of the expense.</value>
    public string Title { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the description of the expense.
    /// </summary>
    /// <value>The description of the expense.</value>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the date of the expense.
    /// </summary>
    /// <value>The date when the expense occurred.</value>
    public DateTime Date { get; set; }

    /// <summary>
    ///     Gets or sets the value of the expense.
    /// </summary>
    /// <value>The monetary value of the expense.</value>
    public decimal Value { get; set; }

    /// <summary>
    ///     Gets or sets the payment type of the expense.
    /// </summary>
    /// <value>The type of payment used for the expense.</value>
    public PaymentType PaymentType { get; set; }
}