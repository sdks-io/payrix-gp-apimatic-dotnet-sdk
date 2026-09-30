using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<FundingParameterType>))]
public sealed record FundingParameterType : OpenStringEnum<FundingParameterType>
{
    private FundingParameterType(string value) : base(value)
    {
    }

    public static readonly FundingParameterType AgentCnp = new("agentCnp");

    public static readonly FundingParameterType AgentCp = new("agentCp");

    public static readonly FundingParameterType CreditCompanyId = new("creditCompanyId");

    public static readonly FundingParameterType DebitCompanyId = new("debitCompanyId");

    public static readonly FundingParameterType Delay = new("delay");

    public static readonly FundingParameterType OffDaysAdditionalDelay = new("offDaysAdditionalDelay");

    public static readonly FundingParameterType SettlementAccountTransferDelay = new("settlementAccountTransferDelay");

    public static readonly FundingParameterType SettlementAccountTransferEnabled = new(
        "settlementAccountTransferEnabled");

    public static readonly FundingParameterType SettlementAccountTransferFloat = new("settlementAccountTransferFloat");

    public static readonly FundingParameterType SettlementAccountTransferMaximum = new(
        "settlementAccountTransferMaximum");

    public static readonly FundingParameterType SettlementAccountTransferMinimum = new(
        "settlementAccountTransferMinimum");

    public static readonly FundingParameterType SettlementAccountTransferPercent = new(
        "settlementAccountTransferPercent");

    public static readonly FundingParameterType CustomBatchCloseTime = new("customBatchCloseTime");

    public static readonly FundingParameterType LateFunding = new("lateFunding");

    public static readonly FundingParameterType _5AmFunding = new("5AmFunding");

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
