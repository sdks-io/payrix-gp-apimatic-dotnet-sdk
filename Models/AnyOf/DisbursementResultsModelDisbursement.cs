using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Disbursement that this disbursementResult resource refers to.
/// </summary>
[JsonConverter(typeof(DisbursementResultsModelDisbursementConverter))]
public record DisbursementResultsModelDisbursement
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<DisbursementsResponse> _disbursementsResponseValue;

    private DisbursementResultsModelDisbursement(Optional<string> stringValue,
        Optional<DisbursementsResponse> disbursementsResponseValue)
    {
        _stringValue = stringValue;
        _disbursementsResponseValue = disbursementsResponseValue;
    }

    public static DisbursementResultsModelDisbursement String(string value) =>
        new(Optional<string>.Some(value), default);

    public static DisbursementResultsModelDisbursement DisbursementsResponse(DisbursementsResponse value) =>
        new(default, Optional<DisbursementsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetDisbursementsResponse(out DisbursementsResponse value) =>
        _disbursementsResponseValue.TryGetValue(out value);

    public static implicit operator DisbursementResultsModelDisbursement(string value) => String(value);

    public static implicit operator DisbursementResultsModelDisbursement(DisbursementsResponse value) =>
        DisbursementsResponse(value);
}

file sealed class DisbursementResultsModelDisbursementConverter : JsonConverter<DisbursementResultsModelDisbursement>
{
    public override DisbursementResultsModelDisbursement Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return DisbursementResultsModelDisbursement.String(value);
        }
        if (JsonSerializer.TryDeserialize<DisbursementsResponse>(root, options, out var disbursementsResponseValue))
        {
            return DisbursementResultsModelDisbursement.DisbursementsResponse(disbursementsResponseValue);
        }
        throw new JsonException($"JSON does not match string or DisbursementsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        DisbursementResultsModelDisbursement value,
        JsonSerializerOptions options)
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
            throw new JsonException(
                $"{nameof(DisbursementResultsModelDisbursement)} contains no valid value to serialize.");
        }
    }
}
