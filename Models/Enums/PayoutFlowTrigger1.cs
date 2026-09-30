using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The event on the Org or Entity that should trigger the creation of an associated Payout resource.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>accountCreate</c> - <b>Primary payment account creation.</b> (primary must be 1)</description></item>
///   <item><description><c>board</c> - <b>Merchant boarding.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PayoutFlowTrigger1>))]
public sealed record PayoutFlowTrigger1 : OpenStringEnum<PayoutFlowTrigger1>
{
    private PayoutFlowTrigger1(string value) : base(value)
    {
    }

    public static readonly PayoutFlowTrigger1 AccountCreate = new("accountCreate");

    public static readonly PayoutFlowTrigger1 Board = new("board");

    public TResult Match<TResult>(Func<TResult> onAccountCreate,
        Func<TResult> onBoard,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AccountCreate => onAccountCreate(),
            _ when this == Board => onBoard(),
            _ => otherwise(Value)
        };

    public void Match(Action onAccountCreate, Action onBoard, Action<string> otherwise)
    {
        if (this == AccountCreate) onAccountCreate();
        else if (this == Board) onBoard();
        else otherwise(Value);
    }
}
