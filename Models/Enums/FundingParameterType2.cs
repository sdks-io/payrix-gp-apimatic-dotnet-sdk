using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The type of fundingParameter that we will be configuring.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>agentCnp</c> - <b>The id to use for boarding merchants that are card not present</b></description></item>
///   <item><description><c>agentCp</c> - <b>The id to use for boarding merchants that are card present</b></description></item>
///   <item><description><c>creditCompanyId</c> - <b>Company credit identifier</b></description></item>
///   <item><description><c>debitCompanyId</c> - <b>Company debit identifier</b></description></item>
///   <item><description><c>delay</c> - <b>Delay</b></description></item>
///   <item><description><c>offDaysAdditionalDelay</c> - <b>Additional delay for off days.</b></description></item>
///   <item><description><c>settlementAccountTransferDelay</c> - <b>The amount of time in days to wait before issuing a transfer, will be counted from the date of the first item within the total settlement amount.</b></description></item>
///   <item><description><c>settlementAccountTransferEnabled</c> - <b>Indication if during settlements credits should be transferred from the merchant's operating account.</b></description></item>
///   <item><description><c>settlementAccountTransferFloat</c> - <b>Additional amount to keep at the merchant's operating account.</b></description></item>
///   <item><description><c>settlementAccountTransferMaximum</c> - <b>The maximum amount needed to transfer funds from merchant's operating account.</b></description></item>
///   <item><description><c>settlementAccountTransferMinimum</c> - <b>The minimum amount needed to transfer funds from the merchant's operating account.</b></description></item>
///   <item><description><c>settlementAccountTransferPercent</c> - <b>The percent amount to transfer from the total settlement amount.</b></description></item>
///   <item><description><c>customBatchCloseTime</c> - <b>The specified time to close a batch</b></description></item>
///   <item><description><c>lateFunding</c> - <b>2 am late funding cutoff time</b></description></item>
///   <item><description><c>5AmFunding</c> - <b>5 am funding cutoff time</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FundingParameterType2>))]
public sealed record FundingParameterType2 : OpenStringEnum<FundingParameterType2>
{
    private FundingParameterType2(string value) : base(value)
    {
    }

    public static readonly FundingParameterType2 AgentCnp = new("agentCnp");

    public static readonly FundingParameterType2 AgentCp = new("agentCp");

    public static readonly FundingParameterType2 CreditCompanyId = new("creditCompanyId");

    public static readonly FundingParameterType2 DebitCompanyId = new("debitCompanyId");

    public static readonly FundingParameterType2 Delay = new("delay");

    public static readonly FundingParameterType2 OffDaysAdditionalDelay = new("offDaysAdditionalDelay");

    public static readonly FundingParameterType2 SettlementAccountTransferDelay = new("settlementAccountTransferDelay");

    public static readonly FundingParameterType2 SettlementAccountTransferEnabled = new(
        "settlementAccountTransferEnabled");

    public static readonly FundingParameterType2 SettlementAccountTransferFloat = new("settlementAccountTransferFloat");

    public static readonly FundingParameterType2 SettlementAccountTransferMaximum = new(
        "settlementAccountTransferMaximum");

    public static readonly FundingParameterType2 SettlementAccountTransferMinimum = new(
        "settlementAccountTransferMinimum");

    public static readonly FundingParameterType2 SettlementAccountTransferPercent = new(
        "settlementAccountTransferPercent");

    public static readonly FundingParameterType2 CustomBatchCloseTime = new("customBatchCloseTime");

    public static readonly FundingParameterType2 LateFunding = new("lateFunding");

    public static readonly FundingParameterType2 _5AmFunding = new("5AmFunding");

    public TResult Match<TResult>(Func<TResult> onAgentCnp,
        Func<TResult> onAgentCp,
        Func<TResult> onCreditCompanyId,
        Func<TResult> onDebitCompanyId,
        Func<TResult> onDelay,
        Func<TResult> onOffDaysAdditionalDelay,
        Func<TResult> onSettlementAccountTransferDelay,
        Func<TResult> onSettlementAccountTransferEnabled,
        Func<TResult> onSettlementAccountTransferFloat,
        Func<TResult> onSettlementAccountTransferMaximum,
        Func<TResult> onSettlementAccountTransferMinimum,
        Func<TResult> onSettlementAccountTransferPercent,
        Func<TResult> onCustomBatchCloseTime,
        Func<TResult> onLateFunding,
        Func<TResult> on_5AmFunding,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AgentCnp => onAgentCnp(),
            _ when this == AgentCp => onAgentCp(),
            _ when this == CreditCompanyId => onCreditCompanyId(),
            _ when this == DebitCompanyId => onDebitCompanyId(),
            _ when this == Delay => onDelay(),
            _ when this == OffDaysAdditionalDelay => onOffDaysAdditionalDelay(),
            _ when this == SettlementAccountTransferDelay => onSettlementAccountTransferDelay(),
            _ when this == SettlementAccountTransferEnabled => onSettlementAccountTransferEnabled(),
            _ when this == SettlementAccountTransferFloat => onSettlementAccountTransferFloat(),
            _ when this == SettlementAccountTransferMaximum => onSettlementAccountTransferMaximum(),
            _ when this == SettlementAccountTransferMinimum => onSettlementAccountTransferMinimum(),
            _ when this == SettlementAccountTransferPercent => onSettlementAccountTransferPercent(),
            _ when this == CustomBatchCloseTime => onCustomBatchCloseTime(),
            _ when this == LateFunding => onLateFunding(),
            _ when this == _5AmFunding => on_5AmFunding(),
            _ => otherwise(Value)
        };

    public void Match(Action onAgentCnp,
        Action onAgentCp,
        Action onCreditCompanyId,
        Action onDebitCompanyId,
        Action onDelay,
        Action onOffDaysAdditionalDelay,
        Action onSettlementAccountTransferDelay,
        Action onSettlementAccountTransferEnabled,
        Action onSettlementAccountTransferFloat,
        Action onSettlementAccountTransferMaximum,
        Action onSettlementAccountTransferMinimum,
        Action onSettlementAccountTransferPercent,
        Action onCustomBatchCloseTime,
        Action onLateFunding,
        Action on_5AmFunding,
        Action<string> otherwise)
    {
        if (this == AgentCnp) onAgentCnp();
        else if (this == AgentCp) onAgentCp();
        else if (this == CreditCompanyId) onCreditCompanyId();
        else if (this == DebitCompanyId) onDebitCompanyId();
        else if (this == Delay) onDelay();
        else if (this == OffDaysAdditionalDelay) onOffDaysAdditionalDelay();
        else if (this == SettlementAccountTransferDelay) onSettlementAccountTransferDelay();
        else if (this == SettlementAccountTransferEnabled) onSettlementAccountTransferEnabled();
        else if (this == SettlementAccountTransferFloat) onSettlementAccountTransferFloat();
        else if (this == SettlementAccountTransferMaximum) onSettlementAccountTransferMaximum();
        else if (this == SettlementAccountTransferMinimum) onSettlementAccountTransferMinimum();
        else if (this == SettlementAccountTransferPercent) onSettlementAccountTransferPercent();
        else if (this == CustomBatchCloseTime) onCustomBatchCloseTime();
        else if (this == LateFunding) onLateFunding();
        else if (this == _5AmFunding) on_5AmFunding();
        else otherwise(Value);
    }
}
