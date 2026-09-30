using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<DisbursementResultCode>))]
public sealed record DisbursementResultCode : OpenStringEnum<DisbursementResultCode>
{
    private DisbursementResultCode(string value) : base(value)
    {
    }

    public static readonly DisbursementResultCode Pending = new("pending");

    public static readonly DisbursementResultCode Internal = new("internal");

    public static readonly DisbursementResultCode Nsf = new("nsf");

    public static readonly DisbursementResultCode BadAccount = new("badAccount");

    public static readonly DisbursementResultCode Unauthorized = new("unauthorized");

    public static readonly DisbursementResultCode General = new("general");

    public static readonly DisbursementResultCode Noc = new("noc");

    public static readonly DisbursementResultCode Parameter = new("parameter");

    public static readonly DisbursementResultCode SameDay = new("sameDay");

    public static readonly DisbursementResultCode TransferDetails = new("transferDetails");

    public static readonly DisbursementResultCode Platform = new("platform");

    public TResult Match<TResult>(Func<TResult> onPending,
        Func<TResult> onInternal,
        Func<TResult> onNsf,
        Func<TResult> onBadAccount,
        Func<TResult> onUnauthorized,
        Func<TResult> onGeneral,
        Func<TResult> onNoc,
        Func<TResult> onParameter,
        Func<TResult> onSameDay,
        Func<TResult> onTransferDetails,
        Func<TResult> onPlatform,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Pending => onPending(),
            _ when this == Internal => onInternal(),
            _ when this == Nsf => onNsf(),
            _ when this == BadAccount => onBadAccount(),
            _ when this == Unauthorized => onUnauthorized(),
            _ when this == General => onGeneral(),
            _ when this == Noc => onNoc(),
            _ when this == Parameter => onParameter(),
            _ when this == SameDay => onSameDay(),
            _ when this == TransferDetails => onTransferDetails(),
            _ when this == Platform => onPlatform(),
            _ => otherwise(Value)
        };

    public void Match(Action onPending,
        Action onInternal,
        Action onNsf,
        Action onBadAccount,
        Action onUnauthorized,
        Action onGeneral,
        Action onNoc,
        Action onParameter,
        Action onSameDay,
        Action onTransferDetails,
        Action onPlatform,
        Action<string> otherwise)
    {
        if (this == Pending) onPending();
        else if (this == Internal) onInternal();
        else if (this == Nsf) onNsf();
        else if (this == BadAccount) onBadAccount();
        else if (this == Unauthorized) onUnauthorized();
        else if (this == General) onGeneral();
        else if (this == Noc) onNoc();
        else if (this == Parameter) onParameter();
        else if (this == SameDay) onSameDay();
        else if (this == TransferDetails) onTransferDetails();
        else if (this == Platform) onPlatform();
        else otherwise(Value);
    }
}
