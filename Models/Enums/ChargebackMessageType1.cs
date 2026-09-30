using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The type of this chargebackMessage.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>assign</c> - <b>Assign the chargeback.</b></description></item>
///   <item><description><c>notate</c> - <b>Add a note to the chargeback.</b></description></item>
///   <item><description><c>acceptLiability</c> - <b>Accept Liability for the Chargeback amount.</b></description></item>
///   <item><description><c>createPreArbitration</c> - <b>Create a pre-arbitration case.</b></description></item>
///   <item><description><c>represent</c> - <b>Represent the chargeback.</b></description></item>
///   <item><description><c>respond</c> - <b>Respond to the chargeback.</b></description></item>
///   <item><description><c>requestArbitration</c> - <b>Request Arbitration. The Merchant wishes to enter arbitration to determine the outcome of the Chargeback.</b></description></item>
///   <item><description><c>createArbitration</c> - <b>Create an arbitration case.</b></description></item>
///   <item><description><c>requestPreArbitration</c> - <b>Request a pre-arbitration case.</b></description></item>
///   <item><description><c>requestResolutionToPreArbitration</c> - <b>Request resolution to a pre-arbitration case.</b></description></item>
///   <item><description><c>respondToDispute</c> - <b>Respond to a dispute.</b></description></item>
///   <item><description><c>respondToPreArbitration</c> - <b>Respond to a pre-arbitration case.</b></description></item>
///   <item><description><c>unaccept</c> - <b>Unaccept the chargeback.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ChargebackMessageType1>))]
public sealed record ChargebackMessageType1 : OpenStringEnum<ChargebackMessageType1>
{
    private ChargebackMessageType1(string value) : base(value)
    {
    }

    public static readonly ChargebackMessageType1 Assign = new("assign");

    public static readonly ChargebackMessageType1 Notate = new("notate");

    public static readonly ChargebackMessageType1 AcceptLiability = new("acceptLiability");

    public static readonly ChargebackMessageType1 CreatePreArbitration = new("createPreArbitration");

    public static readonly ChargebackMessageType1 Represent = new("represent");

    public static readonly ChargebackMessageType1 Respond = new("respond");

    public static readonly ChargebackMessageType1 RequestArbitration = new("requestArbitration");

    public static readonly ChargebackMessageType1 CreateArbitration = new("createArbitration");

    public static readonly ChargebackMessageType1 RequestPreArbitration = new("requestPreArbitration");

    public static readonly ChargebackMessageType1 RequestResolutionToPreArbitration = new(
        "requestResolutionToPreArbitration");

    public static readonly ChargebackMessageType1 RespondToDispute = new("respondToDispute");

    public static readonly ChargebackMessageType1 RespondToPreArbitration = new("respondToPreArbitration");

    public static readonly ChargebackMessageType1 Unaccept = new("unaccept");

    public TResult Match<TResult>(Func<TResult> onAssign,
        Func<TResult> onNotate,
        Func<TResult> onAcceptLiability,
        Func<TResult> onCreatePreArbitration,
        Func<TResult> onRepresent,
        Func<TResult> onRespond,
        Func<TResult> onRequestArbitration,
        Func<TResult> onCreateArbitration,
        Func<TResult> onRequestPreArbitration,
        Func<TResult> onRequestResolutionToPreArbitration,
        Func<TResult> onRespondToDispute,
        Func<TResult> onRespondToPreArbitration,
        Func<TResult> onUnaccept,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Assign => onAssign(),
            _ when this == Notate => onNotate(),
            _ when this == AcceptLiability => onAcceptLiability(),
            _ when this == CreatePreArbitration => onCreatePreArbitration(),
            _ when this == Represent => onRepresent(),
            _ when this == Respond => onRespond(),
            _ when this == RequestArbitration => onRequestArbitration(),
            _ when this == CreateArbitration => onCreateArbitration(),
            _ when this == RequestPreArbitration => onRequestPreArbitration(),
            _ when this == RequestResolutionToPreArbitration => onRequestResolutionToPreArbitration(),
            _ when this == RespondToDispute => onRespondToDispute(),
            _ when this == RespondToPreArbitration => onRespondToPreArbitration(),
            _ when this == Unaccept => onUnaccept(),
            _ => otherwise(Value)
        };

    public void Match(Action onAssign,
        Action onNotate,
        Action onAcceptLiability,
        Action onCreatePreArbitration,
        Action onRepresent,
        Action onRespond,
        Action onRequestArbitration,
        Action onCreateArbitration,
        Action onRequestPreArbitration,
        Action onRequestResolutionToPreArbitration,
        Action onRespondToDispute,
        Action onRespondToPreArbitration,
        Action onUnaccept,
        Action<string> otherwise)
    {
        if (this == Assign) onAssign();
        else if (this == Notate) onNotate();
        else if (this == AcceptLiability) onAcceptLiability();
        else if (this == CreatePreArbitration) onCreatePreArbitration();
        else if (this == Represent) onRepresent();
        else if (this == Respond) onRespond();
        else if (this == RequestArbitration) onRequestArbitration();
        else if (this == CreateArbitration) onCreateArbitration();
        else if (this == RequestPreArbitration) onRequestPreArbitration();
        else if (this == RequestResolutionToPreArbitration) onRequestResolutionToPreArbitration();
        else if (this == RespondToDispute) onRespondToDispute();
        else if (this == RespondToPreArbitration) onRespondToPreArbitration();
        else if (this == Unaccept) onUnaccept();
        else otherwise(Value);
    }
}
