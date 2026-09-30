using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TxnCheckStage>))]
public sealed record TxnCheckStage : OpenStringEnum<TxnCheckStage>
{
    private TxnCheckStage(string value) : base(value)
    {
    }

    public static readonly TxnCheckStage Activation = new("activation");

    public static readonly TxnCheckStage Auth = new("auth");

    public static readonly TxnCheckStage Postauth = new("postauth");

    public static readonly TxnCheckStage Capture = new("capture");

    public static readonly TxnCheckStage Refund = new("refund");

    public TResult Match<TResult>(Func<TResult> onActivation,
        Func<TResult> onAuth,
        Func<TResult> onPostauth,
        Func<TResult> onCapture,
        Func<TResult> onRefund,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Activation => onActivation(),
            _ when this == Auth => onAuth(),
            _ when this == Postauth => onPostauth(),
            _ when this == Capture => onCapture(),
            _ when this == Refund => onRefund(),
            _ => otherwise(Value)
        };

    public void Match(Action onActivation,
        Action onAuth,
        Action onPostauth,
        Action onCapture,
        Action onRefund,
        Action<string> otherwise)
    {
        if (this == Activation) onActivation();
        else if (this == Auth) onAuth();
        else if (this == Postauth) onPostauth();
        else if (this == Capture) onCapture();
        else if (this == Refund) onRefund();
        else otherwise(Value);
    }
}
