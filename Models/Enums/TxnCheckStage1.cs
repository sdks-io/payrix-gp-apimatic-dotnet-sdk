using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The last transaction stage check for risk.
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// <list type="bullet">
///   <item><description><c>activation</c> - <b>Terminal activation.</b></description></item>
///   <item><description><c>auth</c> - <b>Apply this decision during transaction authorization.</b></description></item>
///   <item><description><c>postauth</c> - <b>Apply this decision after transaction authorization.</b></description></item>
///   <item><description><c>capture</c> - <b>Apply this decision during transaction capture.</b></description></item>
///   <item><description><c>refund</c> - <b>Apply this decision when processing a refund.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TxnCheckStage1>))]
public sealed record TxnCheckStage1 : OpenStringEnum<TxnCheckStage1>
{
    private TxnCheckStage1(string value) : base(value)
    {
    }

    public static readonly TxnCheckStage1 Activation = new("activation");

    public static readonly TxnCheckStage1 Auth = new("auth");

    public static readonly TxnCheckStage1 Postauth = new("postauth");

    public static readonly TxnCheckStage1 Capture = new("capture");

    public static readonly TxnCheckStage1 Refund = new("refund");

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
