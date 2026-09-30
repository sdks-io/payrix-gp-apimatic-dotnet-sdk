using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Disbursement that this disbursementRef resource refers to.
/// </summary>
[JsonConverter(typeof(DisbursementRefsModelDisbursementConverter))]
public record DisbursementRefsModelDisbursement
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<DisbursementsResponse> _disbursementsResponseValue;

    private DisbursementRefsModelDisbursement(Optional<string> stringValue,
        Optional<DisbursementsResponse> disbursementsResponseValue)
    {
        _stringValue = stringValue;
        _disbursementsResponseValue = disbursementsResponseValue;
    }

    public static DisbursementRefsModelDisbursement String(string value) => new(Optional<string>.Some(value), default);

    public static DisbursementRefsModelDisbursement DisbursementsResponse(DisbursementsResponse value) =>
        new(default, Optional<DisbursementsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetDisbursementsResponse(out DisbursementsResponse value) =>
        _disbursementsResponseValue.TryGetValue(out value);

    public static implicit operator DisbursementRefsModelDisbursement(string value) => String(value);

    public static implicit operator DisbursementRefsModelDisbursement(DisbursementsResponse value) =>
        DisbursementsResponse(value);
}

file sealed class DisbursementRefsModelDisbursementConverter : JsonConverter<DisbursementRefsModelDisbursement>
{
    public override DisbursementRefsModelDisbursement Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return DisbursementRefsModelDisbursement.String(value);
        }
        if (JsonSerializer.TryDeserialize<DisbursementsResponse>(root, options, out var disbursementsResponseValue))
        {
            return DisbursementRefsModelDisbursement.DisbursementsResponse(disbursementsResponseValue);
        }
        throw new JsonException($"JSON does not match string or DisbursementsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        DisbursementRefsModelDisbursement value,
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
                $"{nameof(DisbursementRefsModelDisbursement)} contains no valid value to serialize.");
        }
    }
}
