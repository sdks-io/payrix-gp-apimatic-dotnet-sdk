using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// If the activity that this Entry refers to is the charging of a Disbursement, then this field stores the identifier of the corresponding Disbursement resource.
/// </summary>
[JsonConverter(typeof(EntriesModelDisbursementConverter))]
public record EntriesModelDisbursement
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<DisbursementsResponse> _disbursementsResponseValue;

    private EntriesModelDisbursement(Optional<string> stringValue,
        Optional<DisbursementsResponse> disbursementsResponseValue)
    {
        _stringValue = stringValue;
        _disbursementsResponseValue = disbursementsResponseValue;
    }

    public static EntriesModelDisbursement String(string value) => new(Optional<string>.Some(value), default);

    public static EntriesModelDisbursement DisbursementsResponse(DisbursementsResponse value) =>
        new(default, Optional<DisbursementsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetDisbursementsResponse(out DisbursementsResponse value) =>
        _disbursementsResponseValue.TryGetValue(out value);

    public static implicit operator EntriesModelDisbursement(string value) => String(value);

    public static implicit operator EntriesModelDisbursement(DisbursementsResponse value) =>
        DisbursementsResponse(value);
}

file sealed class EntriesModelDisbursementConverter : JsonConverter<EntriesModelDisbursement>
{
    public override EntriesModelDisbursement Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return EntriesModelDisbursement.String(value);
        }
        if (JsonSerializer.TryDeserialize<DisbursementsResponse>(root, options, out var disbursementsResponseValue))
        {
            return EntriesModelDisbursement.DisbursementsResponse(disbursementsResponseValue);
        }
        throw new JsonException($"JSON does not match string or DisbursementsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, EntriesModelDisbursement value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetDisbursementsResponse(out var disbursementsResponseValue))
        {
            JsonSerializer.Serialize(writer, disbursementsResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(EntriesModelDisbursement)} contains no valid value to serialize.");
        }
    }
}
