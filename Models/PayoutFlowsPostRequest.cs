using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record PayoutFlowsPostRequest
{
    /// <summary>
    /// The Login that owns this resource.
    /// </summary>
    [JsonPropertyName("login")]
    public required string Login { get; init; }

    /// <summary>
    /// The Login that will own the Payout resource. When set to null, the Payout resource will be owned by the triggerring Entity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payoutLogin")]
    public string? PayoutLogin { get; init; }

    /// <summary>
    /// The identifier of the Org that this payoutFlows resource applies to.
    /// If you set this field, then the payoutFlow applies to all Entities in the Org.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("org")]
    public string? Org { get; init; }

    /// <summary>
    /// The identifier of the Entity that this payoutFlow applies to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("entity")]
    public string? Entity { get; init; }

    /// <summary>
    /// The identifier of a Billing that this PayoutFlow is associated with.
    /// The Billing identifier will be carried over to Payouts created based on this PayoutFlow.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billing")]
    public string? Billing { get; init; }

    [JsonPropertyName("trigger")]
    public required PayoutFlowTrigger1 Trigger { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("schedule")]
    public PayoutFlowSchedule1? Schedule { get; init; }

    /// <summary>
    /// A multiplier that you can use to adjust the schedule set in the 'schedule' field, if it is set to a duration-based trigger, such as daily, weekly, monthly, or annually. This affects the Payout resource that is created by this payoutFlow. This field is specified as an integer and its value determines how the interval is multiplied.
    /// <para>
    /// &lt;details&gt;
    /// &lt;summary&gt;Valid Values&lt;/summary&gt;
    /// </para>
    /// <list type="bullet">
    ///   <item><description><c>1</c>  - <b>Subscription to trigger daily</b>.</description></item>
    /// </list>
    /// <para>
    ///  &lt;/details&gt;
    /// </para>
    /// </summary>
    [JsonPropertyName("scheduleFactor")]
    public int? ScheduleFactor { get; init; } = 1;

    /// <summary>
    /// The date on which payment of the Payout should start.
    /// The date is specified as an eight digit string in YYYYMMDD format, for example, '20160120' for January 20, 2016.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("start")]
    public int? Start { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("um")]
    public PayoutFlowUm1? Um { get; init; }

    /// <summary>
    /// The total amount of the Payout resource that is created.
    /// The units used in this field are determined by the value of the 'um' field on the Payout. If the 'um' field is set to '1' or '3', then this field specifies the Payout percentage to levy in basis points. If the 'um' field is set to '2', then this field specifies the Payout in cents.
    /// </summary>
    [JsonPropertyName("amount")]
    public long? Amount { get; init; } = 10000L;

    /// <summary>
    /// The minium amount of payout that will process.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minimum")]
    public long? Minimum { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payoutInactive")]
    public PayoutInactive1? PayoutInactive { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("skipOffDays")]
    public PayoutFlowsSkipOffDays1? SkipOffDays { get; init; }

    /// <summary>
    /// The secondary billing descriptor to appear on the bank statements in which entities will have automated payouts generated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secondaryDescriptor")]
    public string? SecondaryDescriptor { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currency")]
    public object? Currency { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sameDay")]
    public PayoutFlowsSameDay1? SameDay { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inactive")]
    public Inactive1? Inactive { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("frozen")]
    public Frozen1? Frozen { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
