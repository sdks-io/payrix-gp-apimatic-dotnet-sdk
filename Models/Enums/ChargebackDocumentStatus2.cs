using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The current status of the chargebackDocument.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>created</c> - <b>The ChargebackDocument has been created.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>processed</c> - <b>The ChargebackDocument integration has been successful.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>failed</c> - <b>The ChargebackDocument integration has failed.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ChargebackDocumentStatus2>))]
public sealed record ChargebackDocumentStatus2 : OpenStringEnum<ChargebackDocumentStatus2>
{
    private ChargebackDocumentStatus2(string value) : base(value)
    {
    }

    public static readonly ChargebackDocumentStatus2 Created = new("created");

    public static readonly ChargebackDocumentStatus2 Processed = new("processed");

    public static readonly ChargebackDocumentStatus2 Failed = new("failed");

    public TResult Match<TResult>(Func<TResult> onCreated,
        Func<TResult> onProcessed,
        Func<TResult> onFailed,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Created => onCreated(),
            _ when this == Processed => onProcessed(),
            _ when this == Failed => onFailed(),
            _ => otherwise(Value)
        };

    public void Match(Action onCreated, Action onProcessed, Action onFailed, Action<string> otherwise)
    {
        if (this == Created) onCreated();
        else if (this == Processed) onProcessed();
        else if (this == Failed) onFailed();
        else otherwise(Value);
    }
}
