using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record Adjustment
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
    [JsonPropertyName("login")]
    public Login2? Login { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("entity")]
    public Entity3? Entity { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fromentity")]
    public Fromentity? Fromentity { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("onentity")]
    public Onentity? Onentity { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("disbursement")]
    public Disbursement2? Disbursement { get; init; }

    /// <summary>
    /// The description of this Decision Rule.
    /// This field is stored as a text string and must be between 0 and 100 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The amount of the Adjustment, This field is specified in cents(up to three decimal points).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    public double? Amount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currency")]
    public object? Currency { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("funding")]
    public Funding? Funding { get; init; }

    /// <summary>
    /// The processor that issued this terminalTxnRef.
    /// <para>
    /// &lt;details&gt;
    /// &lt;summary&gt;Valid Values&lt;/summary&gt;
    /// </para>
    /// <para>
    /// - <c>APPLE</c> - <b>Apple Payment Processor</b>
    /// - <c>ELAVON</c> - <b>ELAVON Payment Processor</b>
    /// - <c>FIRSTDATA</c> - <b>FirstData Payment Processor</b>
    /// - <c>GOOGLE</c> - <b>Google Payment Processor</b>
    /// - <c>VANTIV</c> - <b>WorldPay / Vantiv eComm Payment Processor (VAP)</b>
    /// - <c>VCORE</c> - <b>WorldPay / Vantiv Core Payment Processor</b>
    /// - <c>WELLSACH</c> - <b>Wells Fargo Merchant Services Payment Processor (ACH)</b>
    /// - <c>WELLSFARGO</c> - <b>Wells Fargo Merchant Services Payment Processor</b>
    /// - <c>WFSINGLE</c> - <b>Wells Fargo Single Payment Processor</b>
    /// - <c>WORLDPAY</c> - <b>WORLDPAY</b>
    /// - <c>TDBANKCA</c> - <b>TDBANKCA</b>
    /// &lt;/details&gt;
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("platform")]
    public string? Platform { get; init; }

    /// <summary>
    /// FBO account (For-Benefit-Of account) identifier.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fbo")]
    public string? Fbo { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("entry")]
    public EntriesResponse? Entry { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("entryOrigins")]
    public IReadOnlyList<EntryOriginsResponse>? EntryOrigins { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pendingEntry")]
    public PendingEntriesResponse? PendingEntry { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
