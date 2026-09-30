using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The code identifying the disbursement result.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>pending</c> - <b>Disbursement processing is pending account verification.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>internal</c> - <b>Failed. Internal note and/or failure.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>nsf</c> - <b>Failed. Disbursement return due to insufficient funds.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>badAccount</c> - <b>Failed. Disbursement return due to incorrect payment account information.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>unauthorized</c> - <b>Failed. Disbursement return due to customer dispute of authorization.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>general</c> - <b>General note and/or failure.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>noc</c> - <b>Notice of change.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>parameter</c> - <b>Disbursement processing withheld due to parameter configuration.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>sameDay</c> - <b>Failed. Same-day processing note and/or failure.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>transferDetails</c> - <b>Trace number note and/or data.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>platform</c> - <b>Failed. Processor note and/or failure.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DisbursementResultCode2>))]
public sealed record DisbursementResultCode2 : OpenStringEnum<DisbursementResultCode2>
{
    private DisbursementResultCode2(string value) : base(value)
    {
    }

    public static readonly DisbursementResultCode2 Pending = new("pending");

    public static readonly DisbursementResultCode2 Internal = new("internal");

    public static readonly DisbursementResultCode2 Nsf = new("nsf");

    public static readonly DisbursementResultCode2 BadAccount = new("badAccount");

    public static readonly DisbursementResultCode2 Unauthorized = new("unauthorized");

    public static readonly DisbursementResultCode2 General = new("general");

    public static readonly DisbursementResultCode2 Noc = new("noc");

    public static readonly DisbursementResultCode2 Parameter = new("parameter");

    public static readonly DisbursementResultCode2 SameDay = new("sameDay");

    public static readonly DisbursementResultCode2 TransferDetails = new("transferDetails");

    public static readonly DisbursementResultCode2 Platform = new("platform");

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
