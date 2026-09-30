using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// If the activity that this PendingEntry refers to is the paying of a Refund, then this field stores the identifier of the corresponding Refund resource.
/// </summary>
[JsonConverter(typeof(PendingEntriesModelRefundConverter))]
public record PendingEntriesModelRefund
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<RefundsResponse> _refundsResponseValue;

    private PendingEntriesModelRefund(Optional<string> stringValue, Optional<RefundsResponse> refundsResponseValue)
    {
        _stringValue = stringValue;
        _refundsResponseValue = refundsResponseValue;
    }

    public static PendingEntriesModelRefund String(string value) => new(Optional<string>.Some(value), default);

    public static PendingEntriesModelRefund RefundsResponse(RefundsResponse value) =>
        new(default, Optional<RefundsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetRefundsResponse(out RefundsResponse value) => _refundsResponseValue.TryGetValue(out value);

    public static implicit operator PendingEntriesModelRefund(string value) => String(value);

    public static implicit operator PendingEntriesModelRefund(RefundsResponse value) => RefundsResponse(value);
}

file sealed class PendingEntriesModelRefundConverter : JsonConverter<PendingEntriesModelRefund>
{
    public override PendingEntriesModelRefund Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return PendingEntriesModelRefund.String(value);
        }
        if (JsonSerializer.TryDeserialize<RefundsResponse>(root, options, out var refundsResponseValue))
        {
            return PendingEntriesModelRefund.RefundsResponse(refundsResponseValue);
        }
        throw new JsonException($"JSON does not match string or RefundsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, PendingEntriesModelRefund value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetRefundsResponse(out var refundsResponseValue))
        {
            JsonSerializer.Serialize(writer, refundsResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(PendingEntriesModelRefund)} contains no valid value to serialize.");
        }
    }
}
