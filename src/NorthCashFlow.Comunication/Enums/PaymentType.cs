namespace NorthCashFlow.Comunication.Enums;

/// <summary>
///     Defines the types of payment methods available.
/// </summary>
public enum PaymentType
{
    /// <summary>
    ///     Payment made with cash.
    /// </summary>
    Cash = 0,

    /// <summary>
    ///     Payment made using a credit card.
    /// </summary>
    CreditCard = 1,

    /// <summary>
    ///     Payment made using a debit card.
    /// </summary>
    DebitCard = 2,

    /// <summary>
    ///     Payment made using Pix (a Brazilian instant payment system).
    /// </summary>
    Pix = 3
}