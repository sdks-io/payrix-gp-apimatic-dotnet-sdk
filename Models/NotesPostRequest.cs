using System.Collections.Generic;
using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record NotesPostRequest
{
    /// <summary>
    /// The identifier of the Login that owns this notes resource.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("login")]
    public string? Login { get; init; }

    /// <summary>
    /// The identifier of the Txn that relates to this notes resource, Only one of txn, hold, entity, terminalTxn may be set.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("txn")]
    public string? Txn { get; init; }

    /// <summary>
    /// The identifier of the TerminalTxn that relates to this notes resource, Only one of txn, hold, entity, terminalTxn may be set.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("terminalTxn")]
    public string? TerminalTxn { get; init; }

    /// <summary>
    /// The identifier of the Hold that relates to this notes resource, Only one of txn, hold, entity, terminalTxn may be set.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hold")]
    public string? Hold { get; init; }

    /// <summary>
    /// The identifier of the Entity that relates to this notes resource, Only one of txn, hold, entity, terminalTxn may be set.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("entity")]
    public string? Entity { get; init; }

    [JsonPropertyName("type")]
    public required NoteType1 Type { get; init; }

    /// <summary>
    /// Free-form text for adding a message along with the type ,
    /// required in case of type value is in one of these - amexSales, businessSales, consumerSales, deliverySchedule, immediateDeliveryPercent, sevenDayDeliveryPercent, fourteenDayDeliveryPercent, thirtyDayDeliveryPercent, cardPresentSales, motoSales, ecommerceSales, siteVisit, goodsSold, authorizationFlatFee, capturePercentFee, captureFlatFee
    /// else null
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("data")]
    public string? Data { get; init; }

    /// <summary>
    /// A Message/Note regarding this notes resource. This field is stored as a text string.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("note")]
    public string? Note { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inactive")]
    public Inactive1? Inactive { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("frozen")]
    public Frozen1? Frozen { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("noteDocuments")]
    public IReadOnlyList<NoteDocumentsPostRequest>? NoteDocuments { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
