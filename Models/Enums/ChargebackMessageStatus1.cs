using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The current status of the Chargeback.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>requested</c> - <b>The chargeback has been requested.</b></description></item>
///   <item><description><c>processing</c> - <b>The chargeback is currently being processed.</b></description></item>
///   <item><description><c>failed</c> - <b>The chargeback process has failed.</b></description></item>
///   <item><description><c>denied</c> - <b>The chargeback has been denied.</b></description></item>
///   <item><description><c>processed</c> - <b>The chargeback has been successfully processed.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ChargebackMessageStatus1>))]
public sealed record ChargebackMessageStatus1 : OpenStringEnum<ChargebackMessageStatus1>
{
    private ChargebackMessageStatus1(string value) : base(value)
    {
    }

    public static readonly ChargebackMessageStatus1 Requested = new("requested");

    public static readonly ChargebackMessageStatus1 Processing = new("processing");

    public static readonly ChargebackMessageStatus1 Failed = new("failed");

    public static readonly ChargebackMessageStatus1 Denied = new("denied");

    public static readonly ChargebackMessageStatus1 Processed = new("processed");

    public TResult Match<TResult>(Func<TResult> onRequested,
        Func<TResult> onProcessing,
        Func<TResult> onFailed,
        Func<TResult> onDenied,
        Func<TResult> onProcessed,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Requested => onRequested(),
            _ when this == Processing => onProcessing(),
            _ when this == Failed => onFailed(),
            _ when this == Denied => onDenied(),
            _ when this == Processed => onProcessed(),
            _ => otherwise(Value)
        };

    public void Match(Action onRequested,
        Action onProcessing,
        Action onFailed,
        Action onDenied,
        Action onProcessed,
        Action<string> otherwise)
    {
        if (this == Requested) onRequested();
        else if (this == Processing) onProcessing();
        else if (this == Failed) onFailed();
        else if (this == Denied) onDenied();
        else if (this == Processed) onProcessed();
        else otherwise(Value);
    }
}
