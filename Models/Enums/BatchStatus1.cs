using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The current status of this Batch.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>open</c>  - <b>This Batch can accept more Transactions.</b></description></item>
///   <item><description><c>closed</c> - <b>This Batch is closed to new Transactions and is ready to be sent to the processor.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BatchStatus1>))]
public sealed record BatchStatus1 : OpenStringEnum<BatchStatus1>
{
    private BatchStatus1(string value) : base(value)
    {
    }

    public static readonly BatchStatus1 Open = new("open");

    public static readonly BatchStatus1 Closed = new("closed");

    public TResult Match<TResult>(Func<TResult> onOpen, Func<TResult> onClosed, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Open => onOpen(),
            _ when this == Closed => onClosed(),
            _ => otherwise(Value)
        };

    public void Match(Action onOpen, Action onClosed, Action<string> otherwise)
    {
        if (this == Open) onOpen();
        else if (this == Closed) onClosed();
        else otherwise(Value);
    }
}
