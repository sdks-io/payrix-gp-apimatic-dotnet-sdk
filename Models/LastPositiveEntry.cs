using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record LastPositiveEntry
{
    /// <summary>
    /// The ID of this resource.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The date and time at which this resource was created. The format should be YYYY-MM-DD HH:MM:SS.SSSS
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created")]
    [RegularExpression("^\\d{4}-\\d{2}-\\d{2} \\d{2}:\\d{2}:\\d{2}.\\d{4}$")]
    public string? Created { get; init; }

    /// <summary>
    /// The date and time at which this resource was modified. The format should be YYYY-MM-DD HH:MM:SS.SSSS
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("modified")]
    [RegularExpression("^\\d{4}-\\d{2}-\\d{2} \\d{2}:\\d{2}:\\d{2}.\\d{4}$")]
    public string? Modified { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("creator")]
    public Creator18? Creator { get; init; }

    /// <summary>
    /// The identifier of the Login that last modified this resource.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("modifier")]
    public string? Modifier { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("entity")]
    public Entity15? Entity { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("onentity")]
    public Onentity? Onentity { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fromentity")]
    public Fromentity? Fromentity { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("opposingEntry")]
    public OpposingEntry? OpposingEntry { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fund")]
    public Fund2? Fund { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fee")]
    public Fee2? Fee { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("disbursement")]
    public Disbursement1? Disbursement { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refund")]
    public AccountsResponse? Refund { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("settlement")]
    public SettlementsResponse? Settlement { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("txn")]
    public Txn? Txn { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("chargeback")]
    public Chargeback? Chargeback { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("adjustment")]
    public Adjustment? Adjustment { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("profitShare")]
    public ProfitShare? ProfitShare { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("statement")]
    public Statement? Statement { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("event")]
    public EntryEvent1? Event { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eventId")]
    public EventIdModel? EventId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("revShareStatement")]
    public RevShareStatement? RevShareStatement { get; init; }

    /// <summary>
    /// ID of the original event.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("originalEventId")]
    public string? OriginalEventId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("originalEvent")]
    public OriginalEntryEvent1? OriginalEvent { get; init; }

    /// <summary>
    /// A description of this Entry.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("originalCurrency")]
    public object? OriginalCurrency { get; init; }

    /// <summary>
    /// currency conversion rate(up to three decimal points).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currencyRate")]
    public double? CurrencyRate { get; init; }

    /// <summary>
    /// The amount involved in this Entry. It refers to the amount charged, transferred, or disbursed. This field is specified in cents(up to three decimal points).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    public double? Amount { get; init; }

    /// <summary>
    /// Integer boolean that determines whether or not this entry is pending.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pending")]
    public int? Pending { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("isFee")]
    public EntriesIsFee1? IsFee { get; init; }

    /// <summary>
    /// Summary record for archived entries.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("archiveSummary")]
    public int? ArchiveSummary { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pendingEntry")]
    public PendingEntry? PendingEntry { get; init; }

    /// <summary>
    /// The date and time (up to the second) when the initially associated pendingEntry was created. The format should be YYYY-MM-DD HH:MM:SS
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pendingEntryCreated")]
    [RegularExpression("^\\d{4}-\\d{2}-\\d{2} \\d{2}:\\d{2}:\\d{2}")]
    public string? PendingEntryCreated { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("isEFE")]
    public EntriesIsEfe1? IsEfe { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cancellation")]
    public IReadOnlyList<EntryOriginsResponse>? Cancellation { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("disbursementEntries")]
    public IReadOnlyList<DisbursementEntriesResponse>? DisbursementEntries { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("entryOrigins")]
    public IReadOnlyList<EntryOriginsResponse>? EntryOrigins { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lastNegativeOfDisbursement")]
    public DisbursementsResponse? LastNegativeOfDisbursement { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lastPositiveOfDisbursement")]
    public DisbursementsResponse? LastPositiveOfDisbursement { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("opposingEntries")]
    public EntriesResponse? OpposingEntries { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("profitShareResults")]
    public IReadOnlyList<ProfitShareResultsResponse>? ProfitShareResults { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refunds")]
    public IReadOnlyList<RefundsResponse>? Refunds { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reserveEntries")]
    public IReadOnlyList<ReserveEntriesResponse>? ReserveEntries { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
