using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ChargebackMessageType>))]
public sealed record ChargebackMessageType : OpenStringEnum<ChargebackMessageType>
{
    private ChargebackMessageType(string value) : base(value)
    {
    }

    public static readonly ChargebackMessageType Assign = new("assign");

    public static readonly ChargebackMessageType Notate = new("notate");

    public static readonly ChargebackMessageType AcceptLiability = new("acceptLiability");

    public static readonly ChargebackMessageType CreatePreArbitration = new("createPreArbitration");

    public static readonly ChargebackMessageType Represent = new("represent");

    public static readonly ChargebackMessageType Respond = new("respond");

    public static readonly ChargebackMessageType RequestArbitration = new("requestArbitration");

    public static readonly ChargebackMessageType CreateArbitration = new("createArbitration");

    public static readonly ChargebackMessageType RequestPreArbitration = new("requestPreArbitration");

    public static readonly ChargebackMessageType RequestResolutionToPreArbitration = new(
        "requestResolutionToPreArbitration");

    public static readonly ChargebackMessageType RespondToDispute = new("respondToDispute");

    public static readonly ChargebackMessageType RespondToPreArbitration = new("respondToPreArbitration");

    public static readonly ChargebackMessageType Unaccept = new("unaccept");

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
