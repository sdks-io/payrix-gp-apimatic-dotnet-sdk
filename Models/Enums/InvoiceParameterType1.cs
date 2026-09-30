using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The type of Transaction.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>1</c> - <b>Credit Card Only:</b> Sale Transaction, processes a sale and charges the customer.</description></item>
///   <item><description><c>2</c> - <b>Credit Card Only:</b> Auth Transaction, authorizes and holds the requested total on the credit card.</description></item>
///   <item><description><c>3</c> - <b>Credit Card Only:</b> Capture Transaction, finalizes a prior Auth Transaction and charges the customer.</description></item>
///   <item><description><c>4</c> - <b>Credit Card Only:</b> Reverse Authorization, reverses a prior Auth or Sale Transaction and releases the credit hold.</description></item>
///   <item><description><c>5</c> - <b>Credit Card Only:</b> Refund Transaction, refunds a prior Capture or Sale Transaction (total may be specified for a partial refund).</description></item>
///   <item><description><c>7</c> - <b>Echeck Only:</b> Echeck Sale Transaction, sale transaction for ECheck payment.</description></item>
///   <item><description><c>8</c> - <b>Echeck Only:</b> ECheck Refund Transaction, refund transaction for prior ECheck Sale Transaction.</description></item>
///   <item><description><c>11</c> - <b>Echeck Only:</b> Echeck Redeposit Transaction, attempt to redeposit a prior failed eCheck Sale Transaction.</description></item>
///   <item><description><c>12</c> - <b>Echeck Only:</b> Echeck Account Verification Transaction, attempt to verify eCheck payment details.</description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<InvoiceParameterType1>))]
public sealed record InvoiceParameterType1 : OpenStringEnum<InvoiceParameterType1>
{
    private InvoiceParameterType1(string value) : base(value)
    {
    }

    public static readonly InvoiceParameterType1 Apikey = new("apikey");

    public static readonly InvoiceParameterType1 FromEmail = new("fromEmail");

    public static readonly InvoiceParameterType1 ReplyToEmail = new("replyToEmail");

    public static readonly InvoiceParameterType1 Dba = new("dba");

    public static readonly InvoiceParameterType1 Address1 = new("address1");

    public static readonly InvoiceParameterType1 Address2 = new("address2");

    public static readonly InvoiceParameterType1 City = new("city");

    public static readonly InvoiceParameterType1 State = new("state");

    public static readonly InvoiceParameterType1 Zip = new("zip");

    public static readonly InvoiceParameterType1 Country = new("country");

    public static readonly InvoiceParameterType1 Phone = new("phone");

    public static readonly InvoiceParameterType1 Website = new("website");

    public static readonly InvoiceParameterType1 ReceiptTitle = new("receiptTitle");

    public static readonly InvoiceParameterType1 ReceiptMessage = new("receiptMessage");

    public static readonly InvoiceParameterType1 BillingRequired = new("billingRequired");

    public static readonly InvoiceParameterType1 ShippingRequired = new("shippingRequired");

    public static readonly InvoiceParameterType1 ECheckAuthorization = new("eCheckAuthorization");

    public TResult Match<TResult>(Func<TResult> onApikey,
        Func<TResult> onFromEmail,
        Func<TResult> onReplyToEmail,
        Func<TResult> onDba,
        Func<TResult> onAddress1,
        Func<TResult> onAddress2,
        Func<TResult> onCity,
        Func<TResult> onState,
        Func<TResult> onZip,
        Func<TResult> onCountry,
        Func<TResult> onPhone,
        Func<TResult> onWebsite,
        Func<TResult> onReceiptTitle,
        Func<TResult> onReceiptMessage,
        Func<TResult> onBillingRequired,
        Func<TResult> onShippingRequired,
        Func<TResult> onECheckAuthorization,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Apikey => onApikey(),
            _ when this == FromEmail => onFromEmail(),
            _ when this == ReplyToEmail => onReplyToEmail(),
            _ when this == Dba => onDba(),
            _ when this == Address1 => onAddress1(),
            _ when this == Address2 => onAddress2(),
            _ when this == City => onCity(),
            _ when this == State => onState(),
            _ when this == Zip => onZip(),
            _ when this == Country => onCountry(),
            _ when this == Phone => onPhone(),
            _ when this == Website => onWebsite(),
            _ when this == ReceiptTitle => onReceiptTitle(),
            _ when this == ReceiptMessage => onReceiptMessage(),
            _ when this == BillingRequired => onBillingRequired(),
            _ when this == ShippingRequired => onShippingRequired(),
            _ when this == ECheckAuthorization => onECheckAuthorization(),
            _ => otherwise(Value)
        };

    public void Match(Action onApikey,
        Action onFromEmail,
        Action onReplyToEmail,
        Action onDba,
        Action onAddress1,
        Action onAddress2,
        Action onCity,
        Action onState,
        Action onZip,
        Action onCountry,
        Action onPhone,
        Action onWebsite,
        Action onReceiptTitle,
        Action onReceiptMessage,
        Action onBillingRequired,
        Action onShippingRequired,
        Action onECheckAuthorization,
        Action<string> otherwise)
    {
        if (this == Apikey) onApikey();
        else if (this == FromEmail) onFromEmail();
        else if (this == ReplyToEmail) onReplyToEmail();
        else if (this == Dba) onDba();
        else if (this == Address1) onAddress1();
        else if (this == Address2) onAddress2();
        else if (this == City) onCity();
        else if (this == State) onState();
        else if (this == Zip) onZip();
        else if (this == Country) onCountry();
        else if (this == Phone) onPhone();
        else if (this == Website) onWebsite();
        else if (this == ReceiptTitle) onReceiptTitle();
        else if (this == ReceiptMessage) onReceiptMessage();
        else if (this == BillingRequired) onBillingRequired();
        else if (this == ShippingRequired) onShippingRequired();
        else if (this == ECheckAuthorization) onECheckAuthorization();
        else otherwise(Value);
    }
}
